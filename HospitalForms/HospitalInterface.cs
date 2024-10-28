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
    public partial class HospitalInterface : Form
    {
        public enum TiposPersonal
        {
            Medico = 0,
            Paciente = 1,
            PersAdm = 2
        };

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

        }
    }
}
