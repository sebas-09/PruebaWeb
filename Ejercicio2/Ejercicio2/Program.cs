using System;

class Ejercicio2
{
    public static void Main(string[] args)
    {
      
        int edad;
        Console.Write("Ingrese su edad: ");
        while (!Int32.TryParse(Console.ReadLine(), out edad) || edad <= 0)
        {
            Console.WriteLine("Ingrese un número entero válido y mayor a 0.");
            Console.Write("Ingrese su edad: ");
        }

        
        if (edad >= 18)
        {
            
            Console.WriteLine("Usted es mayor de edad.");
        }
        else
        {
            Console.WriteLine("Usted no es mayor de edad.");
        }
    }
}