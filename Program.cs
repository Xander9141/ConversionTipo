using System;
using System.Collections.Generic;

namespace ConversionTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> valores = new List<object>();

            valores.Add(7);
            valores.Add(28);
            valores.Add(-1);
            valores.Add(true);
            valores.Add("chair");

            // Imprimir todos los valores de la lista
            Console.WriteLine("Valores en la lista:");
            foreach (var valor in valores)
            {
                Console.WriteLine(valor);
            }

            int sumaEnteros = 0;

            // Sumar los valores de tipo int en la lista
            foreach (var valor in valores)
            {
                if (valor is int)
                {
                    sumaEnteros += (int)valor;
                }
                else if (valor is string)
                {
                    if (int.TryParse((string)valor, out int parsedInt))
                    {
                        sumaEnteros += parsedInt;
                    }
                }
            }

            // Mostrar la suma de los valores enteros
            Console.WriteLine($"La suma de los valores enteros es: {sumaEnteros}");
        }
    }
}

