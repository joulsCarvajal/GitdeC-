using System;
using System.Collections.Generic;

namespace AppGastos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables necesarias
            int opcion;
            float gasto;

            //Declaramos el stack
            Stack<float> gastos = new Stack<float>();

            do
            {
                Console.Clear();

                Console.WriteLine("1. Agregar gasto");
                Console.WriteLine("2. Mostrar gastos del mes");
                Console.WriteLine("3. Pago para no generar intereses");

                //Escoger una opcion 
                Console.Write("\nEscoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(opcion)
                {
                    case 1:
                        Console.Write("Monto: $");
                        gasto = Convert.ToSingle(Console.ReadLine());

                        gastos.Push(gasto);

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Gastos del mes: \n");

                        foreach(float elemento in gastos)
                        {
                            Console.WriteLine("{0}", elemento);

                        }

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;

                    case 3:
                        float total = 0;

                        foreach(float elemento in gastos)
                        {
                            total += elemento;                            
                        }

                        Console.WriteLine("Pago para no generar intereses: ${0}", total);
                        
                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();

                        break;
                }
            } while (opcion >= 1 && opcion <= 3);
        }
    }
}
