using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckQRCode
{
    public partial class Checkdata : Form
    {
        public string myconnectionstring;
        public Checkdata()
        {
            InitializeComponent();
            myconnectionstring = Directory.GetCurrentDirectory() + "\\Database\\DataCheckQR.db";
            loaddata();
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={myconnectionstring};Version=3;"))
            {
                conn.Open();
                DataTable dt = new DataTable();
                SQLiteDataAdapter adap = new SQLiteDataAdapter($"SELECT * from DataCheckQR WHERE QRMain like '%{txt_search.Text}%'  ", conn);
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={myconnectionstring};Version=3;"))
            {
                conn.Open();
                DataTable dt = new DataTable();
                SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT * from DataCheckQR ", conn);
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 7 && e.Value != null && e.Value.ToString() == "OK"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
