using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    public class Calificacion
    {
        public double Nota { get; private set; }

        public Calificacion(double nota)
        {
            if (nota < 0 || nota > 100)
                throw new ArgumentException("La calificación debe estar entre 0 y 100.");

            Nota = nota;
        }
    }

}
