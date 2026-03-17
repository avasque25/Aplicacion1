class CajeroAutomatico
{
    private Cuenta cuenta;

    public CajeroAutomatico(Cuenta cuentaUsuario)
    {
        cuenta = cuentaUsuario;
    }

    public void Inicio()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n||| CAJERO AUTOMATICO |||");
            Console.WriteLine("1. Ver saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Saldo actual: " + cuenta.VerSaldo());
                    break;

                case 2:
                    Console.Write("Ingrese cantidad a depositar: ");
                    double deposito = double.Parse(Console.ReadLine());
                    cuenta.Depositar(deposito);
                    break;

                case 3:
                    Console.Write("Ingrese cantidad a retirar: ");
                    double retiro = double.Parse(Console.ReadLine());
                    cuenta.Retirar(retiro);
                    break;

                case 4:
                    Console.WriteLine("Gracias por usar el cajero.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4);
    }
}