using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class EstudianteGraduado : Estudiante
    {
        public string Titulo { get; set; }

        public new void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("El estudiante se graduo en: " + this.Titulo);
        }
    }
}
