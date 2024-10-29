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
            InitializeValues();
        }

        private void InitializeValues()
        {
            txtModNombre.Text = pac.Nombre;
            txtModEdad.Text = pac.Edad.ToString();
            txtModEnfermedad.Text = pac.Enfermedad;
            txtModMedico.Text = pac.Medico.Nombre;
        }

        public void SetPaciente(Paciente pac)
        {
            this.pac = pac;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
