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
    public partial class ModHistorialMedForm : Form
    {
        private HistorialMedico histMedico;
        private HistorialMedicoForm historialMedicoForm;
        public ModHistorialMedForm()
        {
            InitializeComponent();
        }

        public ModHistorialMedForm(HistorialMedico histMedico, HistorialMedicoForm historialMedicoForm) : this()
        {
            this.histMedico = histMedico;
            this.historialMedicoForm = historialMedicoForm;

            InitializeValues();
        }

        private void InitializeValues()
        {
            cmbMedico.Items.AddRange(Program.ObtenerLista<Medico>().
                Select(obj => obj.Nombre).ToArray());

            dtpFecha.Value = histMedico.Fecha;
            txtDatos1.Text = histMedico.Texto;
            cmbMedico.SelectedIndex = cmbMedico.FindStringExact(histMedico.Medico.Nombre);

            switch(histMedico)
            {
                case Tratamiento tratamiento:
                    lbTipoHistMed.Text = "Tratamiento";

                    lbDatos1.Text = "Tratamiento:";
                    lbDatos2.Text = "Medicina:";

                    txtDatos2.Text = tratamiento.Medicina;
                    break;
                case Diagnostico diagnostico:
                    lbTipoHistMed.Text = "Diagnostico";

                    lbDatos1.Text = "Diagnostico:";

                    lbDatos2.Visible = false;
                    txtDatos2.Visible = false;
                    break;
            }
        }

        private bool ConfirmarDatos()
        {
            switch (histMedico)
            {
                case Tratamiento tratamiento:
                    return !string.IsNullOrWhiteSpace(cmbMedico.Text) &&
                        Program.ContienePersona(
                            Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text)) &&
                        !string.IsNullOrWhiteSpace(txtDatos1.Text) &&
                        !string.IsNullOrWhiteSpace(txtDatos2.Text);
                case Diagnostico diagnostico:
                    return !string.IsNullOrWhiteSpace(cmbMedico.Text) &&
                        Program.ContienePersona(
                            Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text)) &&
                        !string.IsNullOrWhiteSpace(txtDatos1.Text);
                default:
                    return false;
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            if(ConfirmarDatos())
            {
                switch (histMedico)
                {
                    case Tratamiento tratamiento:
                        tratamiento.ModificarTratamiento(dtpFecha.Value,
                            Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text),
                            txtDatos1.Text, txtDatos2.Text);
                        break;
                    case Diagnostico diagnostico:
                        diagnostico.ModificarDiagnostico(dtpFecha.Value,
                            Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text),
                            txtDatos1.Text);;
                        break;
                }

                Dispose();
            }
        }

        private void ModHistorialMedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            historialMedicoForm.ActualziarHistorialMedico();

            Dispose();
        }
    }
}
