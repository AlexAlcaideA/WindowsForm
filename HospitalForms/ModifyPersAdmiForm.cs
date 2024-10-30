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
    public partial class ModifyPersAdmiForm : Form
    {
        PersonalAdministrativo persAdmin;

        public ModifyPersAdmiForm()
        {
            InitializeComponent();
        }

        public ModifyPersAdmiForm(PersonalAdministrativo persAdm) : this()
        {
            persAdmin = persAdm;

            InitializeValues();
        }

        private void InitializeValues()
        {
            string[] arrAdm = { "Oficinista", "Director", "Economico" };

            cmbModDepart.Items.AddRange(arrAdm);

            txtModNombre.Text = persAdmin.Nombre;
            cmbModDepart.SelectedIndex = cmbModDepart.FindStringExact(
                persAdmin.Departamento);
            dtpFechaContrata.Value = persAdmin.FechaContratacion;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            if(ConfirmarDatos())
            {
                persAdmin.ModificarDatosAdministrativo(txtModNombre.Text,
                    dtpFechaContrata.Value, cmbModDepart.Text);

                Dispose();
            }
        }

        private bool ConfirmarDatos()
        {
            return !string.IsNullOrWhiteSpace(txtModNombre.Text);
        }

        private void ModifyPersAdmiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
