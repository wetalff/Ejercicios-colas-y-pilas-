using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_pila_arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un arreglo de números
            int[] numeros = { 10, 20, 30, 40, 50 };

            // Creamos una pila (Stack) de enteros
            Stack<int> pila = new Stack<int>();

            // Agregamos los elementos del arreglo a la pila
            foreach (int n in numeros)
            {
                pila.Push(n);
                Console.WriteLine($"Se agregó {n} a la pila.");
            }

            Console.WriteLine("\nElementos en la pila (de arriba hacia abajo):");
            foreach (int n in pila)
                Console.WriteLine(n);

            // Quitamos los elementos de la pila uno por uno
            Console.WriteLine("\nEliminando elementos de la pila:");
            while (pila.Count > 0)
                Console.WriteLine($"Se eliminó: {pila.Pop()}");
        }
    }
}
