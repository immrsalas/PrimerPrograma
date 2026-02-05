using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    internal class SistemaCalificaciones
    {

        private List<Alumno> alumnos = new List<Alumno>();

        public void Ejecutar()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Nombre del alumno: ");
                string nombre = Console.ReadLine();

                try
                {
                    Alumno alumno = new Alumno(nombre);

                    CapturarCalificaciones(alumno);

                    alumnos.Add(alumno);

                    MostrarResumenAlumno(alumno);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.Write("¿Registrar otro alumno? (s/n): ");
                continuar = Console.ReadLine().ToLower() == "s";
            }

            MostrarResumenGeneral();
        }

        private void CapturarCalificaciones(Alumno alumno)
        {
            bool agregar = true;

            while (agregar)
            {
                Console.Write("Calificación: ");

                if (double.TryParse(Console.ReadLine(), out double nota))
                {
                    try
                    {
                        alumno.AgregarCalificacion(nota);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }

                Console.Write("¿Agregar otra? (s/n): ");
                agregar = Console.ReadLine().ToLower() == "s";
            }
        }

        private void MostrarResumenAlumno(Alumno alumno)
        {
            Console.WriteLine("\n--- Resumen del alumno ---");
            Console.WriteLine($"Nombre: {alumno.Nombre}");
            Console.WriteLine($"Promedio: {alumno.ObtenerPromedio():F2}");
            Console.WriteLine($"Mayor: {alumno.ObtenerMayor()}");
            Console.WriteLine($"Menor: {alumno.ObtenerMenor()}");
            Console.WriteLine(alumno.EstaAprobado() ? "APROBADO" : "REPROBADO");
            Console.WriteLine();
        }

        private void MostrarResumenGeneral()
        {
            Console.WriteLine("\n=== Resumen General ===");

            foreach (var alumno in alumnos)
            {
                Console.WriteLine($"{alumno.Nombre} -> {alumno.ObtenerPromedio():F2}");
            }
        }
    }
}
