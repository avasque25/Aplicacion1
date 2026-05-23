using Alumnos_ejer;
using Microsoft.Data.Sqlite;

BDAlumno bd = new BDAlumno("Data Source=/home/mvaldez/Documents/progra1.db");


string opcion = "";
do
{
    Console.WriteLine("1. Crear Alumno");
    Console.WriteLine("2. Listar Alumnos");
    Console.WriteLine("Elija una opcion");
    opcion = Console.ReadLine();
    if (opcion == "1")
    {
        Alumno alumno = new Alumno();
        Console.WriteLine("Ingrese el Carnet");
        alumno.Carnet = Console.ReadLine();
        Console.WriteLine("Ingrese los Nombres");
        alumno.Nombres = Console.ReadLine();
        Console.WriteLine("Ingrese el Apellidos");
        alumno.Apellidos = Console.ReadLine();
        Console.WriteLine("Ingrese el Telefono");
        alumno.Telefono = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el DPI");
        alumno.DPI = int.Parse(Console.ReadLine());
        bd.Crear(alumno);
    }

    if (opcion == "2")
    {
        List<Alumno> alumnos = bd.Get();
        foreach (var alumno in alumnos)
        {
            Console.WriteLine("{0}: {1}-{2}", alumno.Carnet, alumno.Nombres, alumno.Apellidos);
        }
    }
} while (opcion != "5");