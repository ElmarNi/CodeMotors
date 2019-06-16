using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CodeMotors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select * from Brands", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cmbBrands.Items.Add(reader[1]);
                        }
                        cmbBrands.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("You have not any Brands");
                    }
                    reader.Close();
                }
                using (SqlCommand command1 = new SqlCommand("select * from Transmissions", connection))
                {
                    SqlDataReader reader = command1.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cmbTransmissons.Items.Add(reader[1]);
                        }
                        cmbTransmissons.SelectedIndex = 0;
                    }
                    reader.Close();
                }
                using (SqlCommand command2 = new SqlCommand("select * from MotorTypes", connection))
                {
                    SqlDataReader reader = command2.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cmbMotorTypes.Items.Add(reader[1]);
                        }
                        cmbMotorTypes.SelectedIndex = 0;
                    }
                    reader.Close();
                }
                string cmd = $"select * from All_autos where[Model name] = '{cmbModels.SelectedItem.ToString()}' and Brand = '{cmbBrands.SelectedItem.ToString()}'";
                DataGridViewUpdater(connection, cmd);
            }
        }

        private void CmbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModels.Items.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdTxt = $"select * from Brands join Models on Models.BrandId = Brands.Id where Brands.Name = '{cmbBrands.SelectedItem.ToString()}'";
                using (SqlCommand command = new SqlCommand(cmdTxt, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cmbModels.Items.Add(reader[3]);
                        }
                        cmbModels.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("You have not any Models");
                    }
                    reader.Close();
                }
                string cmd = $"select * from All_autos where[Model name] = '{cmbModels.SelectedItem.ToString()}' and Brand = '{cmbBrands.SelectedItem.ToString()}'";
                DataGridViewUpdater(connection, cmd);
            }
        }
        private void DataGridViewUpdater(SqlConnection connection, string cmd)
        {
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, connection))
            {
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void CmbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmd = $"select * from All_autos where[Model name] = '{cmbModels.SelectedItem.ToString()}' and Brand = '{cmbBrands.SelectedItem.ToString()}'";
                DataGridViewUpdater(connection, cmd);
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            int modelId = cmbModels.SelectedIndex + 1;
            int motorTypeId = cmbMotorTypes.SelectedIndex + 1;
            int transmissionId = cmbTransmissons.SelectedIndex + 1;
            DateTime dateTime = new DateTime();
            string carName;
            if (txtCarName.Text != string.Empty)
            {
                carName = txtCarName.Text;
            }
            else
            {
                MessageBox.Show("Car name is not valid");
                return;
            }
            decimal motor;
            if (decimal.TryParse(txtMotor.Text, out _) && decimal.Parse(txtMotor.Text) > 0 && decimal.Parse(txtMotor.Text) < 10)
            {
                motor = decimal.Parse(txtMotor.Text);
            }
            else
            {
                MessageBox.Show("Please input a valid Motor");
                return;
            }
            if (txtManuDate.Text.Length > 7 && txtManuDate.Text[4] == '-' && txtManuDate.Text[7] == '-')
            {
                dateTime = new DateTime(int.Parse(txtManuDate.Text.Substring(0, 4)), int.Parse(txtManuDate.Text.Substring(5, 2)), int.Parse(txtManuDate.Text.Substring(8, 2)));
            }
            else
            {
                MessageBox.Show("Manufacture date must be like this for example |2019-05-30|");
                return;
            }
            int millage;
            if (int.TryParse(txtMillage.Text, out _))
            {
                millage = int.Parse(txtMillage.Text);
            }
            else
            {
                MessageBox.Show("Millage is not valid");
                return;
            }
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdTxt = $"insert into Automobils values('{carName}', '2019-05-05', {motorTypeId},{motor},{transmissionId}, {txtColor.Text},{millage},{modelId})";
                using (SqlCommand command = new SqlCommand(cmdTxt, connection))
                {
                    int reader = command.ExecuteNonQuery();
                    if (reader != 0)
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("Dont give up");
                    }
                }
            }
        }
    }
}
