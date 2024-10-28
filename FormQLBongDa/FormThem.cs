using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQLBongDa
{
    public partial class FormThem : Form
    {
        public FormThem()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "" || txtMacauthu.Text == "" || txtNS.Text == "" || cbQuequan.Text == "")
            {
                MessageBox.Show("Chua nhap data");
            }
            else
            {
                string sql = "insert into tbQLCT values('"
                    + txtMacauthu.Text + "','"
                    + txtHoten.Text + "','"
                    + txtNS.Text + "','"
                    + cbQuequan.Text + "')";
                TruyxuatCSDL.Chucnang(sql);
                MessageBox.Show("Da them thanh cong");
                this.Close();
            }
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtHoten.Text = "";
            txtMacauthu.Text = "";
            txtNS.Text = "";
            cbQuequan.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Application.Exit();
        }
    }
}
