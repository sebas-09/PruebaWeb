using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("\n Datos del Estudiante: ");
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Edad: " + this.Edad);
            Console.WriteLine("Calificación: " + this.Calificacion);
        }
    }
}
