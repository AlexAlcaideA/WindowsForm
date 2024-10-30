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
        public ModHistorialMedForm()
        {
            InitializeComponent();
        }

        public ModHistorialMedForm(HistorialMedico histMedico) : this()
        {
            this.histMedico = histMedico;
        }
    }
}
