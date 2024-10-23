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
    public partial class NewTaskForm : Form
    {
        public NewTaskForm()
        {
            InitializeComponent();

            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = " ";
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

        private void dtpStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dtpStartDate.Format = DateTimePickerFormat.Custom;
                dtpStartDate.CustomFormat = " ";
            }
        }
    }
}
