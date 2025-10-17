using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {

 
        static void Main(string[] args)
        {
            // 1. Crear una pila para almacenar las acciones
            Stack<string> pilaAcciones = new Stack<string>();

            Console.WriteLine("=== Simulación de comando 'Deshacer' ===\n");

            // 2. Permitir al usuario ingresar cinco acciones
            Console.WriteLine("Ingrese 5 acciones realizadas (por ejemplo: 'Escribir palabra', 'Borrar línea'):");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Acción {i}: ");
                string accion = Console.ReadLine();
                pilaAcciones.Push(accion);
            }

            // 3. Mostrar todas las acciones almacenadas
            Console.WriteLine("\nAcciones registradas (de la más reciente a la más antigua):");
            MostrarPila(pilaAcciones);

            // 4. Ciclo para preguntar si desea deshacer acciones
            while (pilaAcciones.Count > 0)
            {
                Console.Write("\n¿Desea deshacer la última acción? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "s")
                {
                    string accionDeshecha = pilaAcciones.Pop();
                    Console.WriteLine($"Se ha deshecho la acción: {accionDeshecha}");

                    // 5. Mostrar el estado actual de la pila
                    if (pilaAcciones.Count > 0)
                    {
                        Console.WriteLine("\nAcciones restantes:");
                        MostrarPila(pilaAcciones);
                    }
                    else
                    {
                        Console.WriteLine("\nNo quedan más acciones por deshacer (la pila está vacía).");
                    }
                }
                else if (respuesta == "n")
                {
                    Console.WriteLine("Operación 'Deshacer' cancelada. Saliendo del programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Escriba 's' para sí o 'n' para no.");
                }
            }

            Console.WriteLine("\n=== Fin de la simulación ===");
            Console.ReadKey();
        }

        // Método auxiliar para mostrar el contenido de la pila
        static void MostrarPila(Stack<string> pila)
        {
            foreach (string accion in pila)
            {
                Console.WriteLine($"- {accion}");
            }

        }
    }
}
