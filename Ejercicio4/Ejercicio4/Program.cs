using Ejercicio4;

class MainClass
{
    public static void Main(string[] args)
    {
        
        Estudiante estudiante1 = new Estudiante();

        
        Console.WriteLine("Ingrese el nombre del estudiante: ");
        estudiante1.Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la edad del estudiante: ");
        estudiante1.Edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la calificación del estudiante: ");
        estudiante1.Calificacion = double.Parse(Console.ReadLine());

        
        estudiante1.MostrarInformacion();
    }
}