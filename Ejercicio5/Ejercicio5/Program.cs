using Ejercicio5;

class Principal
{
    public static void Main(string[] args)
    {
        
        EstudianteGraduado graduado1 = new EstudianteGraduado();

        
        Console.WriteLine("Ingrese el nombre del estudiante: ");
        graduado1.Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la edad del estudiante : ");
        graduado1.Edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la calificación del estudiante : ");
        graduado1.Calificacion = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el título del estudiante : ");
        graduado1.Titulo = Console.ReadLine();
        Console.Clear();


        graduado1.MostrarInformacion();
    }
}