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
    public partial class HistorialMedicoForm : Form
    {
        public enum TipoHistorialMedico
        {
            Tratamiento = 1,
            Diagnostico = 2
        }

        private Paciente pac;

        public HistorialMedicoForm()
        {
            InitializeComponent();
        }

        public HistorialMedicoForm(Paciente pac) : this()
        {
            this.pac = pac;

            InitializeValues();
        }

        private void InitializeValues()
        {
            lstbHistorial.Items.AddRange(pac.ListaHistorialMedico().ToArray());
            lbNombrePac.Text = pac.Nombre;
        }

        private void butAnyadir_Click(object sender, EventArgs e)
        {
            AddHistorialMedForm historialMedForms = new AddHistorialMedForm(pac, this);

            historialMedForms.ShowDialog();
        }

        public void ActualziarHistorialMedico()
        {
            lstbHistorial.Items.Clear();
            lstbHistorial.Items.AddRange(pac.ListaHistorialMedico().ToArray());
        }

        private void butMod_Click(object sender, EventArgs e)
        {
            ModHistorialMedForm modHistMedForm = new ModHistorialMedForm();

            modHistMedForm.ShowDialog();
        }
    }
}
