using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckQRCode
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string errorcontent)
        {
            InitializeComponent();
            lbl_contenterror.Text = errorcontent;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
