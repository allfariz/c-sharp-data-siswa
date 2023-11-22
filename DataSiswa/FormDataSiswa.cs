using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataSiswa
{
    public partial class FormDataSiswa : Form
    {   public FormDataSiswa()
        {
      
           InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0 && textBoxTempatLahir.Text.Length > 0 && comboBoxJurusan.Text == "PPLG" || 
                comboBoxJurusan.Text == "TKJT" ||  comboBoxJurusan.Text == "DKV" ||  comboBoxJurusan.Text == "TKRO" || radioButtonLK.Checked && radioButtonPR.Checked)
            {
                string gender = "";
                if (radioButtonLK.Checked)
                {
                    gender = "Laki-Laki";
                }
                else if (radioButtonPR.Checked)
                {
                    gender = "Perempuan";
                }
                FormMain.dt.Rows.Add(textBoxName.Text, (textBoxTempatLahir.Text + ", " + dateTimePicker1.Text), "Laki-Laki", comboBoxJurusan.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data harap diisi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
