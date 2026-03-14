
 static void pares()
 {
        int numero;
        // Solicitar al usuario que ingrese un número entero positivo
        Console.Write("Ingrese un número entero positivo: ");
        numero = int.Parse(Console.ReadLine());

        // Validar que el número sea positivo
        if (numero <= 0)
        {
            Console.WriteLine("El numero ingresado no es positivo.");
            return;
        }

    for (int i = 1; i <= numero; i++)
        {
            // Si el número no es par, continúa con el siguiente
            if (i % 2 != 0)
            {
                continue;
            }

            Console.WriteLine(i);
        }
 }
pares();