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
    public partial class ModifyMedicForm : Form
    {
        private Medico med;
        public ModifyMedicForm()
        {
            InitializeComponent();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void SetMedico(Medico med)
        {
            this.med = med;
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            if(ConfirmarDatos())
            {
                med.ModificarDatos(txtModNombre.Text, txtModEspecialidad.Text,
                    ushort.Parse(txtModExp.Text));
            }
        }

        private bool ConfirmarDatos()
        {
            return !string.IsNullOrWhiteSpace(txtModNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtModEspecialidad.Text) &&
                ushort.TryParse(txtModExp.Text, out _);
        }
    }
}
