using System;

class Ejercicio1
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        
        int resultado = numero1 + numero2;

        Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es: " + resultado);
    }
}