//Crear un programa que pida una cantidad de números indefinidos luego el usuario 
//debe ingresar 0 para terminar el ingreso por ultimo el programa debe mostrar la 
//suma de los números ingresados y el promedio


using System;
class Program
{
    static void Main()
    {
        Double suma = 0;
        int contador = 0;
                Double numero;
        Console.WriteLine("Ingrese números (ingrese 0 para terminar):");
        do
        {
            Console.Write("Número: ");
            numero = Convert.ToDouble(Console.ReadLine());
            if (numero != 0)
            {
                suma += numero;
                contador++;
            }
        } while (numero != 0);

        if (contador > 0)
        {
            Double promedio = suma / contador;
            Console.WriteLine($"La suma de los números ingresados es: {suma}");
            Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números.");
        }
    }
}