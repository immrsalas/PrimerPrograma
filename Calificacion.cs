using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    public class Calificacion
    {
        //Atributos
        public string materia { get; set; }
        public double nota { get; set; }

        //Constructor
        public Calificacion(string materia, double nota)
        {
            this.materia = materia;
            this.nota = nota;
        }
    }
}
