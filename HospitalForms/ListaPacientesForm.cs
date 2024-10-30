using GestionHospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalForms
{
    public partial class ListaPacientesForm : Form
    {
        private Medico med;
        public ListaPacientesForm()
        {
            InitializeComponent();
        }

        public ListaPacientesForm(Medico med) : this()
        {
            this.med = med;
            InitializeList();
        }

        private void InitializeList()
        {
            lstbPacientes.Items.AddRange(med.ListaDePacientes().ToArray());
        }

        public void SetMedico(Medico med)
        {
            this.med = med;
        }

        private void ListaPacientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
