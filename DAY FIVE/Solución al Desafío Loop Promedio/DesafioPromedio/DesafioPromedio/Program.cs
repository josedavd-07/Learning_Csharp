﻿using System;

namespace DesafioPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso = "0";
            int contador = 0;
            int total = 0;
            int numeroActual = 0;

            while (ingreso != "fin")
            {
                Console.WriteLine("El número actual es {0}", numeroActual);
                Console.WriteLine("La cantidad de calificaciones ingresadas es de {0}", contador);
                Console.WriteLine("Cuando desee finalizar la carga de datos, escriba 'fin'");
                Console.WriteLine("Por favor ingrese la siguiente calificación");

                ingreso = Console.ReadLine();

                if(ingreso.Equals("fin"))
                {
                    Console.WriteLine("----------------------------------------");
                    double promedio = (double)total / (double)contador;
                    Console.WriteLine("El promedio obtenido por el alumno fue {0}", promedio);
                }

                if (int.TryParse(ingreso, out numeroActual) && numeroActual > 0 && numeroActual < 11)
                {
                    total += numeroActual;
                }
                else
                {
                    if (!(ingreso.Equals("fin")))
                    {
                        Console.WriteLine("Por favor ingrese un número entre 1 y 10");

                    }
                    continue;
                }
                contador++;
                
            }
            Console.Read();
        }
    }
}
