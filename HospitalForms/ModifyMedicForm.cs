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

        public ModifyMedicForm(Medico med) : this()
        {
            this.med = med;

            InitializeValues();
        }

        private void InitializeValues()
        {
            string[] arrDoc = { "Oftalmologo", "Quirurgica", "Endocrinologia",
                        "Famacologia", "Geriatria"};

            cmbModEspecialidad.Items.AddRange(arrDoc);

            txtModNombre.Text = med.Nombre;
            cmbModEspecialidad.SelectedIndex = cmbModEspecialidad.FindStringExact(
                med.Especialidad);
            txtModExp.Text = med.AñosExperiencia.ToString();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            if(ConfirmarDatos())
            {
                med.ModificarDatos(txtModNombre.Text, cmbModEspecialidad.Text,
                    ushort.Parse(txtModExp.Text));

                Dispose();
            }
        }

        private bool ConfirmarDatos()
        {
            return !string.IsNullOrWhiteSpace(txtModNombre.Text) &&
                !string.IsNullOrWhiteSpace(cmbModEspecialidad.Text) &&
                ushort.TryParse(txtModExp.Text, out _);
        }

        private void ModifyMedicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
