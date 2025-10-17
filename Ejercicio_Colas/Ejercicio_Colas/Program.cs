using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Colas
{
    internal class Program
    {
        //Ejercicio 5: Cola de Atención en Banco
        //Enunciado: Simule el proceso de atención a clientes en una cola de banco utilizando una
        //estructura de cola en C#.
        //Problema a resolver:
        //1.Declarar una cola de tipo string para almacenar los nombres de los clientes.
        //2.Permitir al usuario registrar(Enqueue) varios clientes en la cola.
        //3.Mostrar el estado actual de la cola.
        //4.Atender(Dequeue) al primer cliente y mostrar su nombre.
        //5.Mostrar la cola después de atender al cliente.
        //6.Indicar si la cola está vacía.
        static void Main(string[] args)
        {
            Queue < String > Clientes = new Queue<String>();
            Console.WriteLine("¡Bienvenido! ¡A continuacion mostraremos el proceso de atencion a clientes en un banco! ");
            Console.ReadKey();

            Console.WriteLine("¿Cuantos clientes estan esperando? ");
            
            int cantidad = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Ingrese al cliente numero {i + 1}: ");
                string cliente = Convert.ToString(Console.ReadLine());
                Clientes.Enqueue(cliente);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Estado actual de la cola: ");
            foreach (string client in Clientes)
            {
                Console.WriteLine($"{client}");
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("A continuacion atenderemos al primer cliente");
            Console.WriteLine($"Atendiendo... al cliente de nombre: {Clientes.Dequeue()}");
            Console.WriteLine("¡Cliente correctamente atendido!");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Estado actual de la cola: ");

            foreach (string client in Clientes)
            {
                Console.WriteLine($"{client}");
            }
            Console.WriteLine("--------------------------------------");

            if (Clientes.Count == 0)
            {
                Console.WriteLine("¡Clientes Correctamente atendidos!");
            }
            else
            {
                Console.WriteLine("¡Aun hay clientes por atender!");
            }












        }
    }
}
