using Ejercicio3;
using System;
class Principal
{
    public static void Main(string[] args)
    {

        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Sebastian Monga",
            Edad = 22,
            Calificacion = 18.5
        };

        Console.WriteLine("Nombre: " + estudiante1.Nombre);
        Console.WriteLine("Edad: " + estudiante1.Edad);
        Console.WriteLine("Calificación: " + estudiante1.Calificacion);
    }
}