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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void butNextForm_Click(object sender, EventArgs e)
        {
            NewTaskForm newForm = new NewTaskForm();

            newForm.Show();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
