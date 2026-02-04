using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    public class Alumno
    {

        private List<Calificacion> calificaciones = new List<Calificacion>();

        public string Nombre { get; private set; }

        public Alumno(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            Nombre = nombre;
        }

        public void AgregarCalificacion(double nota)
        {
            calificaciones.Add(new Calificacion(nota));
        }

        public double ObtenerPromedio()
        {
            if (calificaciones.Count == 0)
                return 0;

            return calificaciones.Average(c => c.Nota);
        }

        public double ObtenerMayor()
        {
            return calificaciones.Max(c => c.Nota);
        }

        public double ObtenerMenor()
        {
            return calificaciones.Min(c => c.Nota);
        }

        public bool EstaAprobado()
        {
            return ObtenerPromedio() >= 70;
        }

        public List<Calificacion> ObtenerCalificaciones()
        {
            return calificaciones;
        }
    }
}
