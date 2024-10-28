﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class Paciente : Persona
    {
        private Medico medico;
        private ushort edad;
        private string enfermedad;
        private List<HistorialMedico> historial;
        public Medico Medico { get { return medico; } }
        public ushort Edad {  get { return edad; } }
        public string Enfermedad { get { return enfermedad; } }
        public Paciente() { }

        public Paciente(string name, Medico med, ushort edad, string enfermedad) : base(name) 
        {
            historial = new List<HistorialMedico>();

            medico = med;
            this.edad = edad;
            this.enfermedad = enfermedad;
        }

        public void ModificarPaciente(string nombre, Medico med, ushort edad, string enfermedad)
        {
            this.nombre = nombre;
            medico = med;
            this.edad = edad;
            this.enfermedad = enfermedad;
        }

        public void ModificarTratamiento(DateTime fecha, Medico med, string tratamiento, string medicina)
        {
            Tratamiento hisMed = (Tratamiento)historial.Find(tr => tr.Fecha == fecha && tr is Tratamiento);

            if (hisMed != null)
                hisMed.ModificarTratamiento(fecha, med, tratamiento, medicina);
        }

        public void ModificarDiagnostico(DateTime fecha, Medico med, string nota)
        {
            Diagnostico hisMed = (Diagnostico)historial.Find(tr => tr.Fecha == fecha && tr is Diagnostico);

            if (hisMed != null)
                hisMed.ModificarDiagnostico(fecha, med, nota);
        }

        public void AñadirHistorialMedico(HistorialMedico hisMed)
        {
            historial.Add(hisMed);
        }

        public bool HayTratamientoEnFecha(DateTime fecha)
        {
            return historial.Any(tr => tr.Fecha == fecha && tr is Tratamiento);
        }

        public bool HayDiagnosticoEnFecha(DateTime fecha)
        {
            return historial.Any(tr => tr.Fecha == fecha && tr is Diagnostico);
        }

        public Tratamiento ObtenTratamientoEnFecha(DateTime fecha)
        {
            return (Tratamiento)historial.Find(tr => tr.Fecha == fecha && tr is Tratamiento);
        }

        public Diagnostico ObtenDiagnosticoEnFecha(DateTime fecha)
        {
            return (Diagnostico)historial.Find(tr => tr.Fecha == fecha && tr is Diagnostico);
        }
        public string ListaTratamientos()
        {
            List<HistorialMedico> tratamientos = historial.Where(tratamiento => tratamiento is Tratamiento).ToList();

            StringBuilder sb = new StringBuilder();

            foreach(Tratamiento tr in tratamientos)
            {
                sb.Append(tr);
            }

            return sb.ToString();
        }

        public string ListaDiagnosticos()
        {
            List<HistorialMedico> diagnosticos = historial.Where(diag => diag is Diagnostico).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (Diagnostico diag in diagnosticos)
            {
                sb.Append(diag);
            }

            return sb.ToString();
        }

        public string ListaHistorialMed()
        {
            StringBuilder sb = new StringBuilder();

            foreach (HistorialMedico hm in historial)
            {
                sb.Append(hm);
            }

            return sb.ToString();
        }

        public void EliminarDelHistorialMedico(HistorialMedico hisMed)
        {
            historial.Remove(hisMed);
        }

        public void EliminarseDelMedico()
        {
            medico.EliminarPaciente(this);
        }

        public override string ToString()
        {
            return $@"Paciente {nombre}";
        }

        public string Datos()
        {
            return $@"{nombre} con {enfermedad}, edad {edad} y el medico que lo cuida es {medico.Nombre}";
        }
    }
}
