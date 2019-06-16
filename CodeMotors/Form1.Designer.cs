namespace CodeMotors
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBrands = new System.Windows.Forms.Label();
            this.cmbBrands = new System.Windows.Forms.ComboBox();
            this.cmbModels = new System.Windows.Forms.ComboBox();
            this.lblModels = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCarName = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtManuDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMotorTypes = new System.Windows.Forms.ComboBox();
            this.lblMotorType = new System.Windows.Forms.Label();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTransmissons = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMillage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrands.ForeColor = System.Drawing.Color.Teal;
            this.lblBrands.Location = new System.Drawing.Point(6, 17);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(105, 32);
            this.lblBrands.TabIndex = 0;
            this.lblBrands.Text = "Brands";
            // 
            // cmbBrands
            // 
            this.cmbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrands.FormattingEnabled = true;
            this.cmbBrands.Location = new System.Drawing.Point(12, 61);
            this.cmbBrands.Name = "cmbBrands";
            this.cmbBrands.Size = new System.Drawing.Size(200, 37);
            this.cmbBrands.TabIndex = 1;
            this.cmbBrands.SelectedIndexChanged += new System.EventHandler(this.CmbBrands_SelectedIndexChanged);
            // 
            // cmbModels
            // 
            this.cmbModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModels.FormattingEnabled = true;
            this.cmbModels.Location = new System.Drawing.Point(227, 61);
            this.cmbModels.Name = "cmbModels";
            this.cmbModels.Size = new System.Drawing.Size(200, 37);
            this.cmbModels.TabIndex = 2;
            this.cmbModels.SelectedIndexChanged += new System.EventHandler(this.CmbModels_SelectedIndexChanged);
            // 
            // lblModels
            // 
            this.lblModels.AutoSize = true;
            this.lblModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModels.ForeColor = System.Drawing.Color.Teal;
            this.lblModels.Location = new System.Drawing.Point(221, 17);
            this.lblModels.Name = "lblModels";
            this.lblModels.Size = new System.Drawing.Size(107, 32);
            this.lblModels.TabIndex = 2;
            this.lblModels.Text = "Models";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 205);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.ForeColor = System.Drawing.Color.Teal;
            this.lblCarName.Location = new System.Drawing.Point(6, 114);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(142, 32);
            this.lblCarName.TabIndex = 5;
            this.lblCarName.Text = "Car Name";
            // 
            // txtCarName
            // 
            this.txtCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarName.Location = new System.Drawing.Point(12, 158);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(197, 34);
            this.txtCarName.TabIndex = 6;
            // 
            // txtManuDate
            // 
            this.txtManuDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManuDate.Location = new System.Drawing.Point(227, 158);
            this.txtManuDate.Name = "txtManuDate";
            this.txtManuDate.Size = new System.Drawing.Size(197, 34);
            this.txtManuDate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(221, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manufacture date";
            // 
            // cmbMotorTypes
            // 
            this.cmbMotorTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotorTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotorTypes.FormattingEnabled = true;
            this.cmbMotorTypes.Location = new System.Drawing.Point(441, 61);
            this.cmbMotorTypes.Name = "cmbMotorTypes";
            this.cmbMotorTypes.Size = new System.Drawing.Size(200, 37);
            this.cmbMotorTypes.TabIndex = 3;
            // 
            // lblMotorType
            // 
            this.lblMotorType.AutoSize = true;
            this.lblMotorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorType.ForeColor = System.Drawing.Color.Teal;
            this.lblMotorType.Location = new System.Drawing.Point(435, 17);
            this.lblMotorType.Name = "lblMotorType";
            this.lblMotorType.Size = new System.Drawing.Size(171, 32);
            this.lblMotorType.TabIndex = 9;
            this.lblMotorType.Text = "Motor Types";
            // 
            // txtMotor
            // 
            this.txtMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotor.Location = new System.Drawing.Point(441, 158);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(197, 34);
            this.txtMotor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(435, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Motor";
            // 
            // cmbTransmissons
            // 
            this.cmbTransmissons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransmissons.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransmissons.FormattingEnabled = true;
            this.cmbTransmissons.Location = new System.Drawing.Point(655, 61);
            this.cmbTransmissons.Name = "cmbTransmissons";
            this.cmbTransmissons.Size = new System.Drawing.Size(200, 37);
            this.cmbTransmissons.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(649, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Transmission";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(655, 158);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(197, 34);
            this.txtColor.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(649, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Color";
            // 
            // txtMillage
            // 
            this.txtMillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMillage.Location = new System.Drawing.Point(879, 61);
            this.txtMillage.Name = "txtMillage";
            this.txtMillage.Size = new System.Drawing.Size(197, 34);
            this.txtMillage.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(873, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Millage";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Teal;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(879, 114);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(197, 78);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add Car";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 526);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtMillage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTransmissons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMotor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMotorTypes);
            this.Controls.Add(this.lblMotorType);
            this.Controls.Add(this.txtManuDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbModels);
            this.Controls.Add(this.lblModels);
            this.Controls.Add(this.cmbBrands);
            this.Controls.Add(this.lblBrands);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.ComboBox cmbBrands;
        private System.Windows.Forms.ComboBox cmbModels;
        private System.Windows.Forms.Label lblModels;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtManuDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMotorTypes;
        private System.Windows.Forms.Label lblMotorType;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTransmissons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMillage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Add;
    }
}

