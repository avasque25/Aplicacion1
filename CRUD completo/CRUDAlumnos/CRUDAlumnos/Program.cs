using CRUDAlumnos;

string connectionString =
    "Server=localhost;Database=EscuelaDB;Trusted_Connection=True;TrustServerCertificate=True;";

BDAlumno bd = new BDAlumno(connectionString);

string opcion = "";

do
{
    Console.WriteLine("\n===== MENU CRUD =====");
    Console.WriteLine("1. Crear Alumno");
    Console.WriteLine("2. Listar Alumnos");
    Console.WriteLine("3. Actualizar Alumno");
    Console.WriteLine("4. Eliminar Alumno");
    Console.WriteLine("5. Salir");

    Console.Write("Seleccione una opcion: ");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":

            Alumno nuevo = new Alumno();

            Console.Write("Carnet: ");
            nuevo.Carnet = Console.ReadLine();

            Console.Write("Nombres: ");
            nuevo.Nombres = Console.ReadLine();

            Console.Write("Apellidos: ");
            nuevo.Apellidos = Console.ReadLine();

            Console.Write("Telefono: ");
            nuevo.Telefono = int.Parse(Console.ReadLine());

            Console.Write("DPI: ");
            nuevo.DPI = long.Parse(Console.ReadLine());

            bd.Crear(nuevo);

            break;

        case "2":

            List<Alumno> alumnos = bd.Get();

            Console.WriteLine("\nLISTA DE ALUMNOS");

            foreach (var alumno in alumnos)
            {
                Console.WriteLine(
                    $"{alumno.Carnet} | {alumno.Nombres} {alumno.Apellidos}"
                );
            }

            break;

        case "3":

            Console.Write("Ingrese el carnet del alumno: ");
            string carnetUpdate = Console.ReadLine();

            Alumno alumnoActualizar = bd.Get(carnetUpdate);

            if (alumnoActualizar != null)
            {
                Console.Write("Nuevo nombre: ");
                alumnoActualizar.Nombres = Console.ReadLine();

                Console.Write("Nuevo apellido: ");
                alumnoActualizar.Apellidos = Console.ReadLine();

                Console.Write("Nuevo telefono: ");
                alumnoActualizar.Telefono = int.Parse(Console.ReadLine());

                Console.Write("Nuevo DPI: ");
                alumnoActualizar.DPI = long.Parse(Console.ReadLine());

                bd.Update(alumnoActualizar);
            }
            else
            {
                Console.WriteLine("Alumno no encontrado");
            }

            break;

        case "4":

            Console.Write("Ingrese el carnet a eliminar: ");
            string carnetEliminar = Console.ReadLine();

            bd.Eliminar(carnetEliminar);

            break;

        case "5":

            Console.WriteLine("Saliendo del programa...");
            break;

        default:

            Console.WriteLine("Opcion invalida");
            break;
    }

} while (opcion != "5");