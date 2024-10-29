using GestionHospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalForms
{
    public static class Program
    {
        public static Hospital hospital;


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            hospital = new Hospital();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HospitalInterface());
        }

        public static void AnyadirPersonal(Persona persona)
        {
            hospital.DarDeAlta(persona);
        }

        public static List<Persona> ObtenerPersonal()
        {
            return hospital.ListaPersonasHospital();
        }

        public static List<Medico> ObtenerMedicos()
        {
            return hospital.ListaMedicos();
        }

        public static Medico ContieneMedico(string nombreDoc)
        {
            return hospital.EncontrarPerosnaPorNombre<Medico>(nombreDoc);
        }

        public static bool ContienePersona(Persona pers)
        {
            return hospital.ContienePersona(pers);
        }

        public static T EncontrarPersonaPorNombre<T>(string nombre) where T : Persona
        {
            return hospital.EncontrarPerosnaPorNombre<T>(nombre);
        }

        public static void EliminarPaciente(Paciente p)
        {
            hospital.EliminarPaciente(p);
        }

        public static List<Paciente> ListaPacientesMedico(Medico med)
        {
            return hospital.ListaPacientesDeMedico(med);
        }
    }
}
