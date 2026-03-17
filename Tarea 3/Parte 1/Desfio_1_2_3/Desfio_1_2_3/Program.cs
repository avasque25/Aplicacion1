
using System;

namespace Desafio_1_2_3
{
    // Clase para el desafío 2
    class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
                return 0;
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // DESAFÍO 1
            IngresosUsuario();

            // DESAFÍO 2
            Calculadora calc = new Calculadora();

            Console.WriteLine("\n-----Calculadora básica-----");

            Console.Write("\nIngrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nOperaciones básicas:");
            Console.WriteLine("Suma: " + calc.Sumar(num1, num2));
            Console.WriteLine("Resta: " + calc.Restar(num1, num2));
            Console.WriteLine("Multiplicación: " + calc.Multiplicar(num1, num2));
            Console.WriteLine("División: " + calc.Dividir(num1, num2));

            // DESAFÍO 3 
            SumaSegura();

            Console.ReadLine();
        }

        // static del desafío 1
        static void IngresosUsuario()
        {
            Console.WriteLine("-----Ingreso de ingresos mensuales-----");
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            double suma = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Ingrese ingreso del mes " + i + ": ");
                double ingreso = Convert.ToDouble(Console.ReadLine());
                suma += ingreso;
            }

            double promedio = suma / 3;

            Console.WriteLine($"\nHola {nombre}, en total ganaste {suma} y promediaste {promedio}");
        }

        // static del desafío 3
        static void SumaSegura()
        {
            try
            {
                Console.WriteLine("\n-----Suma segura-----");

                Console.Write("\nIngrese el primer valor: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el segundo valor: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int resultado = num1 + num2;
                Console.WriteLine("Resultado: " + resultado);
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Debe ingresar valores numéricos válidos.");
            }
            finally
            {
                Console.WriteLine("Fin del proceso.");
            }
        }
    }
}