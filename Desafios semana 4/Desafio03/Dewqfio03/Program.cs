using System;

class Program
{
    static void Main()
        //guardado e ingreso de notas 
    {
        double suma = 0;
        int cantidad = 0;

        while (true)
        //ingreso de notas hasta que el usuario escriba "fin"
        {
            Console.Write("Ingrese una nota (1-10) o escriba 'fin': ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "fin")
            {
                break;
            }

            if (double.TryParse(entrada, out double nota))
            {
                if (nota >= 1 && nota <= 10)
                {
                    suma += nota;
                    cantidad++;
                }
                else
                {
                    Console.WriteLine("La nota debe estar entre 1 y 10.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número o 'fin'.");
            }
        }
        //cálculo del promedio
        if (cantidad > 0)
        {
            double promedio = suma / cantidad;
            Console.WriteLine("El promedio del estudiante es: " + promedio);
        }
        else
        {
            Console.WriteLine("No se ingresaron notas.");
        }
    }
}