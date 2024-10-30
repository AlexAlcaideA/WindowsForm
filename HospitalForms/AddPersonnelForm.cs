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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalForms
{
    public partial class AddPersonnelForm : Form
    {
        public enum TiposPersonal
        {
            Medico = 0,
            Paciente = 1,
            PersAdm = 2
        };
        public AddPersonnelForm()
        {
            InitializeComponent();
            ActualizarListaMedicos();
        }

        private void cmbAnyTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAnyDatos1.Visible = false;
            lbAnyDatos2.Visible = false;
            lbAnyDatos3.Visible = false;

            lbAnyFechaContrato.Visible = false;

            txtAnyDatos1.Visible = false;
            txtAnyDatos2.Visible = false;
            txtAnyDatos3.Visible = false;

            cmbAnyDatosLista.Visible = false;

            dtpFechaContrato.Visible = false;

            switch ((TiposPersonal)cmbAnyTipo.SelectedIndex)
            {
                case TiposPersonal.Medico:
                    lbAnyDatos1.Text = "Especialidad:";
                    lbAnyDatos2.Text = "Años experiencia:";
                    cmbAnyDatosLista.Items.Clear();

                    string[] arrDoc = { "Oftalmologo", "Quirurgica", "Endocrinologia",
                        "Famacologia", "Geriatria"};

                    cmbAnyDatosLista.Items.AddRange(arrDoc);

                    lbAnyDatos1.Visible = true;
                    lbAnyDatos2.Visible = true;

                    txtAnyDatos2.Visible = true;
                    cmbAnyDatosLista.Visible = true;
                    break;
                case TiposPersonal.Paciente:
                    lbAnyDatos1.Text = "Enfermedad:";
                    lbAnyDatos2.Text = "Edad:";
                    lbAnyDatos3.Text = "Nombre doctor:";

                    lbAnyDatos1.Visible = true;
                    lbAnyDatos2.Visible = true;
                    lbAnyDatos3.Visible = true;

                    txtAnyDatos1.Visible = true; //Enfermedad
                    txtAnyDatos2.Visible = true; //Edad
                    txtAnyDatos3.Visible = true; //Nombre doctor
                    break;
                case TiposPersonal.PersAdm:
                    lbAnyDatos1.Text = "Puesto:";
                    cmbAnyDatosLista.Items.Clear();

                    string[] arrAdm = { "Oficinista", "Director", "Economico" };

                    cmbAnyDatosLista.Items.AddRange(arrAdm);

                    lbAnyDatos1.Visible = true;
                    cmbAnyDatosLista.Visible = true;

                    lbAnyFechaContrato.Visible = true;
                    dtpFechaContrato.Visible = true;
                    break;
            }
        }

        private Medico ConstruirMedico()
        {
            return new Medico(txtAnyNombre.Text, cmbAnyDatosLista.Text,
                ushort.Parse(txtAnyDatos2.Text));
        }

        private Paciente ConstruirPaciente()
        {
            return new Paciente(txtAnyNombre.Text, 
                Program.EncontrarPersonaPorNombre<Medico>(txtAnyDatos3.Text),
                ushort.Parse(txtAnyDatos2.Text), txtAnyDatos1.Text);
        }

        private PersonalAdministrativo ConstruirPersAdministrativo()
        {
            return new PersonalAdministrativo(txtAnyNombre.Text,
                dtpFechaContrato.Value, cmbAnyDatosLista.Text);
        }

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda
            string textoBusqueda = txtFiltroNombre.Text.ToLower();

            // Filtrar los elementos según el texto de búsqueda
            var elementosFiltrados = Program.ObtenerMedicos().Where(elemento => elemento.Nombre.ToLower().Contains(textoBusqueda))
                .ToArray();

            // Limpiar y actualizar con los elementos filtrados
            lstbMedicos.Items.Clear();
            lstbMedicos.Items.AddRange(elementosFiltrados);
        }

        private void ActualizarListaMedicos()
        {
            var elementosFiltrados = Program.ObtenerMedicos().ToArray();

            // Limpiar y actualizar con los elementos filtrados
            lstbMedicos.Items.Clear();
            lstbMedicos.Items.AddRange(elementosFiltrados);
        }

        private void butAnyAlta_Click(object sender, EventArgs e)
        {
            switch ((TiposPersonal)cmbAnyTipo.SelectedIndex)
            {
                case TiposPersonal.Medico:
                    if (ComprobarDatosMedico())
                    {
                        Program.AnyadirPersonal(ConstruirMedico());
                        Dispose();
                    }
                    break;
                case TiposPersonal.Paciente:
                    if (ComprobarDatosPaciente())
                    {
                        Medico tempMed = Program.EncontrarPersonaPorNombre<Medico>(txtAnyDatos3.Text);

                        Paciente tempPac = ConstruirPaciente();

                        Program.AnyadirPersonal(tempPac);
                        tempMed.AñadirPaciente(tempPac);

                        Dispose();
                    }
                    break;
                case TiposPersonal.PersAdm:
                    if(ComprobarDatosPersAdministrativo())
                    {
                        Program.AnyadirPersonal(ConstruirPersAdministrativo());
                        Dispose();
                    }
                    break;
            }
        }

        private bool ComprobarDatosMedico()
        {
            return !string.IsNullOrWhiteSpace(txtAnyNombre.Text) &&
                ushort.TryParse(txtAnyDatos2.Text, out _) &&
                !string.IsNullOrWhiteSpace(cmbAnyDatosLista.Text);
        }

        private bool ComprobarDatosPaciente()
        {
            return !string.IsNullOrWhiteSpace(txtAnyNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtAnyDatos1.Text) &&
                ushort.TryParse(txtAnyDatos2.Text, out _) &&
                !string.IsNullOrWhiteSpace(txtAnyDatos3.Text) &&
                Program.ContienePersona(
                    Program.EncontrarPersonaPorNombre<Medico>(txtAnyDatos3.Text));
        }

        private bool ComprobarDatosPersAdministrativo()
        {
            return !string.IsNullOrWhiteSpace(txtAnyNombre.Text) &&
                dtpFechaContrato.Checked &&
                !string.IsNullOrWhiteSpace(cmbAnyDatosLista.Text);
        }

        private void AddPersonnelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
