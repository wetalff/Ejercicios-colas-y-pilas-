using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_cola_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un arreglo de nombres
            string[] nombres = { "Ana", "Luis", "María", "Carlos", "Sofía" };

            // Creamos una cola (Queue) de cadenas
            Queue<string> cola = new Queue<string>();

            // Agregamos los elementos del arreglo a la cola
            foreach (string nombre in nombres)
            {
                cola.Enqueue(nombre);
                Console.WriteLine($"Se agregó {nombre} a la cola.");
            }

            Console.WriteLine("\nElementos en la cola (de primero a último):");
            foreach (string nombre in cola)
                Console.WriteLine(nombre);

            // Quitamos los elementos de la cola uno por uno
            Console.WriteLine("\nAtendiendo elementos de la cola:");
            while (cola.Count > 0)
                Console.WriteLine($"Se eliminó: {cola.Dequeue()}");
        }
    }
}
