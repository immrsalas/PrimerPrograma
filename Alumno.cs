using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    public class Alumno
    {
        
        //Atributos
        private string nombre { get; set; }

        private string matricula { get; set; }

        private List<Calificacion> calificaciones;


        //Constructor
        public Alumno(string nombre, string matricula)
        {
            this.nombre = nombre;
            this.matricula = matricula;
            calificaciones = new List<Calificacion>();

        }

        public void AgregarCalificacion(Calificacion calificacion)
        {
            calificaciones.Add(calificacion);
        }

        public double CalcularPromedio()
        {
            if (calificaciones.Count == 0)
                return 0;
            double suma = 0;
            foreach (var calificacion in calificaciones)
            {
                suma += calificacion.nota;
            }
            return suma / calificaciones.Count;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}, Matrícula: {matricula}, Promedio: {CalcularPromedio():F2}");
        }
    }
}
