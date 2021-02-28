using System;

namespace Evaluacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            int edad = 0;
            double altura = 0.0;


            Console.WriteLine("Bienvenido, por favor ingrese su edad");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);
            if (edad >= 16)
            {
                Console.WriteLine("Lamentablemente usted ha superado el limite de edad para el parque :(");
            }
            else
            {

              Console.WriteLine("Bienvenido");

                Console.WriteLine("¿cual es tu altura? En metros");
                cadena = Console.ReadLine();
                altura = Convert.ToDouble(cadena);

                if (altura < 1.55)
                {
                    Console.WriteLine("Puedes subir a todas las atracciones salvo las montañas rusas");
                }
                else
                {
                    Console.WriteLine("¡Felicidades! ¡Puedes subir a todas las atracciones");

                }
                
            }




            Console.ReadKey();

        }
    }
}   
