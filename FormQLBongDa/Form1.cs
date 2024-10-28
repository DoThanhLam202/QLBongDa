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
    public partial class Form1 : Form
    {
        //private DataTable data;
        //private int p;
        private DataTable data;
        private int count;
        public Form1()
        {
            InitializeComponent();
        }

        //public void Hienthi()
        //{
        //    txtMacauthu.Text = data.Rows[p][0].ToString();
        //    txtHoten.Text = data.Rows[p][1].ToString();
        //    txtNS.Text = data.Rows[p][2].ToString();
        //    txtQuequan.Text = data.Rows[p][3].ToString();
        //}

        public void Hienthi()
        {
            txtMacauthu.Text = data.Rows[count][0].ToString();
            txtHoten.Text = data.Rows[count][1].ToString();
            txtNS.Text = data.Rows[count][2].ToString();
            txtQuequan.Text = data.Rows[count][3].ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //data = TruyxuatCSDL.getBang("select * from tbQLCT");
            //p = data.Rows.Count - 1;
            //Hienthi();

            data = TruyxuatCSDL.getBang("select * from tbQLCT");
            count = data.Rows.Count - 1;
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThem frmThem = new FormThem();
            frmThem.Show();
            data = TruyxuatCSDL.getBang("select * from tbQLCT");
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            count = 0;
            Hienthi();
            //p = 0;
            //Hienthi();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            //if(p > 0)
            //{
            //    p = p - 1;
            //}
            //Hienthi();
            if(count >0)
            {
                count -= 1;
            }
            Hienthi();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if(count < data.Rows.Count-1)
            {
                count += 1;
            }
            Hienthi();
            //if(p < data.Rows.Count -1)
            //{
            //    p = p + 1;
            //    Hienthi();
            //}
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            count = data.Rows.Count - 1;
            Hienthi();
            //p = data.Rows.Count - 1;
            //Hienthi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtTimkiem.Text == "")
            {
                TruyxuatCSDL.getBang("select * from tbQLCT");
            }
            else
                TruyxuatCSDL.getBang("select * from tbQLCT where MaCT='"+txtTimkiem.Text+"'");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update tbCauThu set Hoten = N'" +
                txtHoten.Text + "', NgaySinh = N'" +
                txtNS.Text + "', QueQuan = N'" +
                txtQuequan.Text + "'   where MaCT=N'" +
                txtMacauthu.Text + "'";
            TruyxuatCSDL.Chucnang(sql);
            //data = TruyxuatCSDL.getBang("select * from tbQLCT");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
