using System;

namespace Formulario
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            Console.WriteLine("Inserte su nombre completo, por favor: ");
            nombre = Console.ReadLine();
            Console.WriteLine();
            int edad;
            Console.WriteLine("Escriba su edad, por favor: ");
            edad = Convert.ToInt32(Console.ReadLine()); //Faltaba el Convert
            Console.WriteLine();
            String telefono;
            Console.WriteLine("Escriba su numero de telefono, por favor: ");
            telefono = Console.ReadLine();
            Console.WriteLine();
            String correo;
            Console.WriteLine("Inserte su correo electronico, por favor: ");
            correo = Console.ReadLine();
            Console.WriteLine();
            String ocupacion;
            Console.WriteLine("Cual es su ocupacion: ");
            ocupacion = Console.ReadLine();
            Console.WriteLine();
            {
            edad = 18;
                {
                    if (edad != 18)
                    {
                        Console.WriteLine("Entras a la escupidera de Salty");
                    }
                    else if (edad != 17)
                    {
                        Console.WriteLine("Eres un chaneque, vete a la zona de los pequeñines");
                    }
                    else
                    {
                        Console.WriteLine("nji");
                    }
                }
            }
        }
    }
}
