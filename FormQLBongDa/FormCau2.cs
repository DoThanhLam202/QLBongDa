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
    public partial class FormCau2 : Form
    {
        public FormCau2()
        {
            InitializeComponent();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtData.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fn = new FontDialog();
            if(fn.ShowDialog() == DialogResult.OK)
            {
                rtxtData.Font = fn.Font;
            }    
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            if(cl.ShowDialog()== DialogResult.OK)
            {
                rtxtData.SelectionColor = cl.Color;
            }    
        }
    }
}
