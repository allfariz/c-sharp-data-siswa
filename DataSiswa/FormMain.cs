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
    public partial class FormMain : Form
    {
        public static DataTable dt = new DataTable();

        public FormMain()
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = dt;

            dt.Columns.Add("Nama");
            dt.Columns.Add("Tanggal Lahir");
            dt.Columns.Add("Jenis Kelamin");
            dt.Columns.Add("Jurusan");
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            new FormDataSiswa().Show();
        }
    }
}
