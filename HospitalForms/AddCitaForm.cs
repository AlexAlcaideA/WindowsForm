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
    public partial class AddCitaForm : Form
    {
        private HospitalInterface hosp;

        public AddCitaForm()
        {
            InitializeComponent();
        }

        public AddCitaForm(HospitalInterface hospital) : this()
        {
            hosp = hospital;

            InitializeValues();
        }

        private void InitializeValues()
        {
            Persona[] listaPersonas;

            cmbPaciente.Items.Clear();
            cmbMedico.Items.Clear();

            listaPersonas = Program.ObtenerLista<Medico>().ToArray();
            cmbMedico.Items.AddRange(listaPersonas);

            listaPersonas = Program.ObtenerLista<Paciente>().ToArray();
            cmbPaciente.Items.AddRange(listaPersonas);
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            if(ConfirmarDatos())
            {

            }
        }

        private bool ConfirmarDatos()
        {
            return dtpFechaCita.Checked &&
                !string.IsNullOrWhiteSpace(cmbMedico.Text) &&
                Program.ContienePersona(
                    Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text)) &&
                !string.IsNullOrWhiteSpace(cmbPaciente.Text) &&
                Program.ContienePersona(
                    Program.EncontrarPersonaPorNombre<Paciente>(cmbPaciente.Text));
        }

        private Cita ConstruirCita()
        {
            return new Cita(dtpFechaCita.Value,
                Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text),
                Program.EncontrarPersonaPorNombre<Paciente>(cmbPaciente.Text));
        }

    }
}
