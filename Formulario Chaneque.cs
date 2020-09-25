using System;
using System.Security.Cryptography.X509Certificates;

namespace 99
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int edad;
            String ocupacion;
            int telefono;
            String correo;

            Console.WriteLine("Bienvenido usuario, regístrate por favor");

            Console.WriteLine("Inserte su nombre completo empezando por apellidos, por favor: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Escriba su numero de telefono, por favor: ");
            telefono = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserte su correo electronico, por favor: ");
            correo = Console.ReadLine();

            Console.WriteLine("Cual es su ocupacion: ");
            ocupacion = Console.ReadLine();

            Console.WriteLine("Escriba su edad, por favor: ");
            edad = Convert.ToInt32(Console.ReadLine());


            int x, y, z;
            x = edad;
            y = 17;
            z = 18;
            {
                if (x < y)
                {
                    Console.WriteLine("Eres un chaneque, vete a la zona de los pequeñines");
                }
                else
                {
                    Console.WriteLine("Entras a la escupidera de Salty");
                }


                Console.WriteLine(nombre);
                Console.WriteLine(telefono);
                Console.WriteLine(correo);
                Console.WriteLine(ocupacion);
                Console.WriteLine(edad);
            }
        }
    }
}
