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
    public partial class ModifyPacForm : Form
    {
        private Paciente pac;

        public ModifyPacForm()
        {
            InitializeComponent();
        }

        public ModifyPacForm(Paciente pac) : this()
        {
            this.pac = pac;

            InitializeValues();
        }

        private void InitializeValues()
        {
            txtModNombre.Text = pac.Nombre;
            txtModEdad.Text = pac.Edad.ToString();
            txtModEnfermedad.Text = pac.Enfermedad;
            txtModMedico.Text = pac.Medico.Nombre;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            if(ConfirmarDatos())
            {
                pac.ModificarPaciente(txtModNombre.Text,
                    Program.EncontrarPersonaPorNombre<Medico>(txtModMedico.Text),
                    ushort.Parse(txtModEdad.Text),
                    txtModEnfermedad.Text);

                Dispose();
            }
        }

        private bool ConfirmarDatos()
        {
            return !string.IsNullOrWhiteSpace(txtModNombre.Text) &&
                ushort.TryParse(txtModEdad.Text, out _) &&
                !string.IsNullOrWhiteSpace(txtModEnfermedad.Text) &&
                !string.IsNullOrWhiteSpace(txtModMedico.Text) &&
                Program.ContienePersona(
                    Program.EncontrarPersonaPorNombre<Medico>(txtModMedico.Text));
        }

        private void ModifyPacForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
