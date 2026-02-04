using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    internal class SistemaCalificaciones
    {

        public void RegistrarAlumno()
        {
            Console.WriteLine("Registro de Alumno");
            Console.WriteLine("------------------");
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la matrícula del alumno: ");
            string matricula = Console.ReadLine();
            Alumno nuevoAlumno = new Alumno(nombre, matricula);
            Console.WriteLine("Alumno registrado exitosamente.");
        }

        public void BuscarAlumno()
        {
            Console.WriteLine("Búsqueda de Alumno");
            Console.WriteLine("------------------");
            Console.Write("Ingrese la matrícula del alumno a buscar: ");
            string matricula = Console.ReadLine();
            // Aquí se implementaría la lógica para buscar al alumno en una base de datos o lista
            Console.WriteLine($"Alumno con matrícula {matricula} encontrado.");
        }

        public void GenerarReporte()
        {
                       Console.WriteLine("Generación de Reporte de Calificaciones");
            Console.WriteLine("---------------------------------------");
            // Aquí se implementaría la lógica para generar el reporte de calificaciones
            Console.WriteLine("Reporte generado exitosamente.");
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("Sistema de Calificaciones");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Registrar Alumno");
            Console.WriteLine("2. Buscar Alumno");
            Console.WriteLine("3. Generar Reporte de Calificaciones");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
        }
    }
}
