using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Services
{
    public class CitaService
    {
        private readonly List<Cita> citas = new List<Cita>();

        public List<Cita> ObtenerCitas() => citas;

        public bool VerificarDisponibilidad(DateTime fecha, int barberoId)
        {
            return !citas.Any(c => c.Fecha == fecha && c.BarberoId == barberoId);
        }

        public void ReservarCita(Cita cita)
        {
            citas.Add(cita);
        }

        public void CancelarCita(int citaId)
        {
            var cita = citas.FirstOrDefault(c => c.CitaId == citaId);
            if (cita != null)
            {
                citas.Remove(cita);
            }
        }
    }
}