using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.Format = DateTimePickerFormat.Short;
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTitle.ToString()) &&
                !string.IsNullOrWhiteSpace(txtDescription.ToString()) &&
                (chbProd.Checked || chbPreProd.Checked || chbDemo.Checked))
            {
                MessageBox.Show("Done correctly");
            }
            else
                MessageBox.Show("Some camps need to be completed");
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbDemo_CheckedChanged(object sender, EventArgs e)
        {
            if(chbDemo.Checked)
            {
                chbProd.Checked = false;
                chbPreProd.Checked = false;
            }
        }

        private void chbPreProd_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPreProd.Checked)
            {
                chbProd.Checked = false;
                chbDemo.Checked = false;
            }
        }

        private void chbProd_CheckedChanged(object sender, EventArgs e)
        {
            if (chbProd.Checked)
            {
                chbDemo.Checked = false;
                chbPreProd.Checked = false;
            }
        }
    }
}
