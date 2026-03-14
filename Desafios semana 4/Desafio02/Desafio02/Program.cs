
static void Primo()
{
    int numero;
    bool esPrimo = true;

    Console.Write("Ingrese un número entero positivo: ");
    numero = int.Parse(Console.ReadLine());

    if (numero <= 0)
    {
        Console.WriteLine("El número no es positivo.");
        return;
    }

    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0)
        {
            esPrimo = false;
            break;
        }
    }

    if (esPrimo && numero > 1)
    {
        Console.WriteLine("El número es primo.");
    }
    else
    {
        Console.WriteLine("El número no es primo.");
    }
}

Primo();