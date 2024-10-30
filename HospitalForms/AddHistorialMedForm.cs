﻿using GestionHospital;
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

        public AddHistorialMedForm()
        {
            InitializeComponent();
        }

        public AddHistorialMedForm(Paciente pac) : this()
        {
            paciente = pac;

            lbDatos1.Enabled = false;
            lbDatos2.Enabled = false;

            txtDatos1.Enabled = false;
            txtDatos2.Enabled = false;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            if(ConfirmarDatos(cmbHistMed.SelectedItem as HistorialMedico))
            {
                switch((HistorialMedicoForm.TipoHistorialMedico)cmbHistMed.SelectedIndex + 1)
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

        private bool ConfirmarDatos(HistorialMedico histMed)
        {
            switch(histMed)
            {
                case Tratamiento tratamiento:
                    return dtpFecha.Checked &&
                        !string.IsNullOrWhiteSpace(cmbMedico.Text) &&
                        Program.ContienePersona(
                            Program.EncontrarPersonaPorNombre<Medico>(cmbMedico.Text)) &&
                        !string.IsNullOrWhiteSpace(txtDatos1.Text) &&
                        !string.IsNullOrWhiteSpace(txtDatos2.Text);

                case Diagnostico diagnostico:
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

                    lbDatos2.Enabled = true;
                    lbDatos2.Text = "Medicina:";

                    break;
                case HistorialMedicoForm.TipoHistorialMedico.Diagnostico:
                    txtDatos1.Clear();

                    lbDatos1.Text = "Diagnostico:";

                    lbDatos2.Enabled = false;
                    break;
            }
        }
    }
}