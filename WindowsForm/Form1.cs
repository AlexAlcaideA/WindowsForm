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
                (cbProd.Checked || cbPreProd.Checked || cbDemo.Checked))
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

        private void cbProd_CheckedChanged(object sender, EventArgs e)
        {
            if(cbProd.Checked)
            {
                cbPreProd.Checked = false;
                cbDemo.Checked = false;
            }
        }

        private void cbPreProd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPreProd.Checked)
            {
                cbProd.Checked = false;
                cbDemo.Checked = false;
            }
        }

        private void cbDemo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDemo.Checked)
            {
                cbPreProd.Checked = false;
                cbProd.Checked = false;
            }
        }
    }
}
