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
using static HospitalForms.HospitalInterface;

namespace HospitalForms
{
    public partial class HospitalInterface : Form
    {
        public enum TiposPersonal
        {
            Medico = 1,
            Paciente = 2,
            PersAdm = 3
        };

        private string nombreBusqueda;
        private TiposPersonal tiposPersonal;

        private ModifyPacForm formPac;

        public HospitalInterface()
        {
            InitializeComponent();
        }

        private void butAnyadirPersonal_Click(object sender, EventArgs e)
        {
            AddPersonnelForm formulario = new AddPersonnelForm();
            formulario.ShowDialog();
        }

        private void butActualizarLista_Click(object sender, EventArgs e)
        {
            lstbPersonal.Items.Clear();
            if(Program.ObtenerPersonal() != null)
                lstbPersonal.Items.AddRange(Program.ObtenerPersonal().ToArray());
        }

        private void lstbPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstbPersonal.SelectedItem)
            {
                case Medico medico:
                    DesactivarBoton(butModHistorialMed);
                    DesactivarBoton(butElimPaciente);
                    ActivarBoton(butListPacMed);
                    break;

                case Paciente paciente:
                    ActivarBoton(butModHistorialMed);
                    ActivarBoton(butElimPaciente);
                    DesactivarBoton(butListPacMed);
                    break;

                case PersonalAdministrativo persAdmin:
                    DesactivarBoton(butModHistorialMed);
                    DesactivarBoton(butElimPaciente);
                    DesactivarBoton(butListPacMed);
                    break;

                default:
                    DesactivarBoton(butModHistorialMed);
                    DesactivarBoton(butElimPaciente);
                    DesactivarBoton(butListPacMed);
                    break;
            }
        }

        private void DesactivarBoton(Button but)
        {
            but.Enabled = false;
            but.BackColor = Color.Gray;
            but.ForeColor = Color.DarkGray;
        }

        private void ActivarBoton(Button but)
        {
            but.Enabled = true;
            but.BackColor = SystemColors.Control;
            but.ForeColor = SystemColors.ControlText;
        }

        private void cmbTipoPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(cmbTipoPersonas.SelectedIndex.ToString(), out tiposPersonal);
            FiltroBusqueda();
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            nombreBusqueda = txtBuscarNombre.Text.ToLower();
            FiltroBusqueda();
        }

        private void FiltroBusqueda() //Se tiene que controlar los casos en que el txt sea null
        {
            Persona[] elementosFiltrados;

            switch (tiposPersonal)
            {
                case TiposPersonal.Medico:
                    elementosFiltrados = Program.ObtenerPersonal().Where(elemento =>
                    elemento.Nombre.ToLower().Contains(nombreBusqueda) &&
                    elemento is Medico).ToArray();
                    break;
                case TiposPersonal.Paciente:
                    elementosFiltrados = Program.ObtenerPersonal().Where(elemento =>
                    elemento.Nombre.ToLower().Contains(nombreBusqueda) &&
                    elemento is Paciente).ToArray();
                    break;
                case TiposPersonal.PersAdm:
                    elementosFiltrados = Program.ObtenerPersonal().Where(elemento =>
                    elemento.Nombre.ToLower().Contains(nombreBusqueda) &&
                    elemento is PersonalAdministrativo).ToArray();
                    break;
            }            
        }

        private void butModDatos_Click(object sender, EventArgs e)
        {
            switch (lstbPersonal.SelectedItem)
            {
                case Medico medico:
                    ModifyMedicForm formMed = new ModifyMedicForm();

                    formMed.SetMedico(medico);

                    formMed.ShowDialog();
                    break;

                case Paciente paciente:

                    if(formPac == null || formPac.IsDisposed)
                    {
                        formPac = new ModifyPacForm();

                        formPac.SetPaciente(paciente);
                        formPac.Show();
                    }
                    break;

                case PersonalAdministrativo persAdmin:
                    
                    break;
            }
        }

        private void butElimPaciente_Click(object sender, EventArgs e)
        {
            Program.EliminarPaciente(lstbPersonal.SelectedItem as Paciente);
        }

        private void butListPacMed_Click(object sender, EventArgs e)
        {
            if (lstbPersonal.SelectedItem != null)
            {
                Medico medicoSeleccionado = lstbPersonal.SelectedItem as Medico;

                if(medicoSeleccionado != null)
                {
                    ListaPacientesForm listPacForm = new ListaPacientesForm();

                    listPacForm.SetMedico(lstbPersonal.SelectedItem as Medico);
                    listPacForm.Show();
                }
            } 
        }
    }
}
