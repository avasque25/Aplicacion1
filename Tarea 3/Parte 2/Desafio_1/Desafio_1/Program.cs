
using System;

namespace DesafiioInicioSesion
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaSesion();
            Console.ReadLine();
        }

        static void SistemaSesion()
        {
            Console.WriteLine("=== REGISTRO ===");

            Console.Write("Crea un usuario: ");
            string usuarioRegistrado = Console.ReadLine();

            Console.Write("Crea una contraseña: ");
            string contraseñaRegistrada = Console.ReadLine();

            Console.WriteLine("\n=== INICIO DE SESIÓN ===");

            Console.Write("Ingrese usuario: ");
            string UsuarioInicio = Console.ReadLine();

            Console.Write("Ingrese contraseña: ");
            string ContraseñaInicio = Console.ReadLine();

            if (UsuarioInicio == usuarioRegistrado && ContraseñaInicio == contraseñaRegistrada)
            {
                Console.WriteLine("Inicio de sesión exitoso ");
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos ");
            }
        }
    }
}