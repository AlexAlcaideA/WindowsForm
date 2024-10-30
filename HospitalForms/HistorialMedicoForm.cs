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
        };

        public enum Meses
        {
            Enero = 1,
            Febrero = 2,
            Marzo = 3,
            Abril = 4,
            Mayo = 5,
            Junio = 6,
            Julio = 7,
            Agosto = 8,
            Septiembre = 9,
            Octubre = 10,
            Noviembre = 11,
            Diciembre = 12
        };

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
            ModHistorialMedForm modHistMedForm = new ModHistorialMedForm(lstbHistorial.SelectedItem as HistorialMedico, this);

            modHistMedForm.ShowDialog();
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltroBusqueda();
        }

        private void txtAnyo_TextChanged(object sender, EventArgs e)
        {
            FiltroBusqueda();
        }

        private void FiltroBusqueda() //Se tiene que controlar los casos en que el txt sea null
        {
            HistorialMedico[] elementosFiltrados;

            int anyo;

            if (int.TryParse(txtAnyo.Text.Trim(), out anyo) || string.IsNullOrWhiteSpace(txtAnyo.Text))
            {
                elementosFiltrados = pac.ListaHistorialMedico().Where(elemento =>
                    (string.IsNullOrWhiteSpace(cmbMes.Text) ||
                    elemento.Fecha.Month == cmbMes.SelectedIndex) &&
                    (string.IsNullOrWhiteSpace(txtAnyo.Text) ||
                    elemento.Fecha.Year == anyo)).ToArray();

                lstbHistorial.Items.Clear();
                lstbHistorial.Items.AddRange(elementosFiltrados);
            }
        }
    }
}
