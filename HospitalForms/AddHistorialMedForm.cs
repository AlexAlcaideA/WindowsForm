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
    public partial class AddHistorialMedForm : Form
    {
        private Paciente paciente;

        private HistorialMedicoForm historialMedicoForm;

        public event EventHandler ActualizarListaHistorialMed;

        public AddHistorialMedForm()
        {
            InitializeComponent();
        }

        public AddHistorialMedForm(Paciente pac, HistorialMedicoForm historialMedicoForm) : this()
        {
            paciente = pac;
            this.historialMedicoForm = historialMedicoForm;

            lbDatos1.Visible = false;
            lbDatos2.Visible = false;

            txtDatos1.Visible = false;
            txtDatos2.Visible = false;

            cmbMedico.Items.AddRange(Program.ObtenerLista<Medico>().
                Select(obj => obj.Nombre).ToArray());
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            HistorialMedicoForm.TipoHistorialMedico opcionEscogida =
                (HistorialMedicoForm.TipoHistorialMedico)cmbHistMed.SelectedIndex + 1;

            if (ConfirmarDatos(opcionEscogida))
            {
                switch(opcionEscogida)
                {
                    case HistorialMedicoForm.TipoHistorialMedico.Tratamiento:
                        paciente.AñadirHistorialMedico(ConstruirTratamiento());
                        break;
                    case HistorialMedicoForm.TipoHistorialMedico.Diagnostico:
                        paciente.AñadirHistorialMedico(ConstruirDiagnostico());
                        break;
                }
                
                Dispose();
            }
        }

        private bool ConfirmarDatos(HistorialMedicoForm.TipoHistorialMedico opcion)
        {
            switch(opcion)
            {
                case HistorialMedicoForm.TipoHistorialMedico.Tratamiento:
                    return dtpFecha.Checked &&
                        !string.IsNullOrWhiteSpace(cmbMedico.Text) &&
                        Program.ContienePersona(
                            Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text)) &&
                        !string.IsNullOrWhiteSpace(txtDatos1.Text) &&
                        !string.IsNullOrWhiteSpace(txtDatos2.Text);

                case HistorialMedicoForm.TipoHistorialMedico.Diagnostico:
                    return dtpFecha.Checked &&
                        !string.IsNullOrWhiteSpace(cmbMedico.Text) &&
                        Program.ContienePersona(
                            Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text)) &&
                        !string.IsNullOrWhiteSpace(txtDatos1.Text);

                default:
                    return false;
            }
        }

        private Tratamiento ConstruirTratamiento()
        {
            return new Tratamiento(dtpFecha.Value,
                Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text),
                txtDatos1.Text, txtDatos2.Text);
        }

        private Diagnostico ConstruirDiagnostico()
        {
            return new Diagnostico(dtpFecha.Value,
                Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text),
                txtDatos1.Text);
        }

        private void cmbHistMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((HistorialMedicoForm.TipoHistorialMedico)cmbHistMed.SelectedIndex + 1)
            {
                case HistorialMedicoForm.TipoHistorialMedico.Tratamiento:
                    txtDatos1.Clear();
                    txtDatos2.Clear();

                    lbDatos1.Text = "Tratamiento:";
                    lbDatos1.Visible = true;

                    lbDatos2.Text = "Medicina:";
                    lbDatos2.Visible = true;

                    txtDatos1.Visible = true;
                    txtDatos2.Visible = true;
                    break;
                case HistorialMedicoForm.TipoHistorialMedico.Diagnostico:
                    txtDatos1.Clear();

                    lbDatos1.Text = "Diagnostico:";
                    lbDatos1.Visible = true;

                    txtDatos1.Visible = true;

                    lbDatos2.Visible = false;
                    txtDatos2.Visible = false;
                    break;
            }
        }

        private void AddHistorialMedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            historialMedicoForm.ActualziarHistorialMedico();

            Dispose();
        }
    }
}
