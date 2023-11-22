namespace DataSiswa
{
    partial class FormDataSiswa
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxTempatLahir = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonLK = new System.Windows.Forms.RadioButton();
            this.radioButtonPR = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxJurusan = new System.Windows.Forms.ComboBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(76, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(182, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxTempatLahir
            // 
            this.textBoxTempatLahir.Location = new System.Drawing.Point(76, 84);
            this.textBoxTempatLahir.Name = "textBoxTempatLahir";
            this.textBoxTempatLahir.Size = new System.Drawing.Size(88, 20);
            this.textBoxTempatLahir.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 84);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 7, 27, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2023, 7, 27, 0, 0, 0, 0);
            // 
            // radioButtonLK
            // 
            this.radioButtonLK.AutoSize = true;
            this.radioButtonLK.Location = new System.Drawing.Point(3, 3);
            this.radioButtonLK.Name = "radioButtonLK";
            this.radioButtonLK.Size = new System.Drawing.Size(64, 17);
            this.radioButtonLK.TabIndex = 3;
            this.radioButtonLK.TabStop = true;
            this.radioButtonLK.Text = "Laki-laki";
            this.radioButtonLK.UseVisualStyleBackColor = true;
            // 
            // radioButtonPR
            // 
            this.radioButtonPR.AutoSize = true;
            this.radioButtonPR.Location = new System.Drawing.Point(94, 3);
            this.radioButtonPR.Name = "radioButtonPR";
            this.radioButtonPR.Size = new System.Drawing.Size(79, 17);
            this.radioButtonPR.TabIndex = 4;
            this.radioButtonPR.TabStop = true;
            this.radioButtonPR.Text = "Perempuan";
            this.radioButtonPR.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonLK);
            this.panel1.Controls.Add(this.radioButtonPR);
            this.panel1.Location = new System.Drawing.Point(76, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 23);
            this.panel1.TabIndex = 5;
            // 
            // comboBoxJurusan
            // 
            this.comboBoxJurusan.FormattingEnabled = true;
            this.comboBoxJurusan.Items.AddRange(new object[] {
            "PPLG",
            "TKJT",
            "DKV",
            "TKRO"});
            this.comboBoxJurusan.Location = new System.Drawing.Point(79, 155);
            this.comboBoxJurusan.Name = "comboBoxJurusan";
            this.comboBoxJurusan.Size = new System.Drawing.Size(179, 21);
            this.comboBoxJurusan.TabIndex = 6;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(79, 197);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 23);
            this.buttonSimpan.TabIndex = 7;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(174, 197);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(75, 23);
            this.buttonBatal.TabIndex = 8;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tpt, tgl lahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Jenis_Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pendidikan";
            // 
            // FormDataSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.comboBoxJurusan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxTempatLahir);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormDataSiswa";
            this.Text = "Data Siswa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxTempatLahir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonLK;
        private System.Windows.Forms.RadioButton radioButtonPR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxJurusan;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}