using System; // Importa el espacio de nombres System, que contiene clases fundamentales para la programación en C#
using System.Collections.Generic; // Importa el espacio de nombres para trabajar con colecciones genéricas
using System.Linq; // Importa el espacio de nombres para trabajar con consultas LINQ
using System.Text; // Importa el espacio de nombres para trabajar con texto y codificaciones
using System.Threading.Tasks; // Importa el espacio de nombres para trabajar con tareas asincrónicas

namespace TPG1
{
    // Definición de la clase OperacionesLogicas
    class OperacionesLogicas
    {
        // Método estático que realiza comparaciones lógicas
        public static void RealizarComparaciones()
        {
            // Solicita al usuario que ingrese un número y lo convierte a entero
            Console.Write("Ingrese un número: ");
            int num1 = int.Parse(Console.ReadLine());
            
            // Solicita al usuario que ingrese otro número y lo convierte a entero
            Console.Write("Ingrese otro número: ");
            int num2 = int.Parse(Console.ReadLine());

            // Imprime el título de las operaciones lógicas
            Console.WriteLine("\nOperaciones Lógicas:");
            
            // Realiza e imprime el resultado de la comparación mayor que
            Console.WriteLine($"{num1} > {num2} = {num1 > num2}");
            
            // Realiza e imprime el resultado de la comparación menor que
            Console.WriteLine($"{num1} < {num2} = {num1 < num2}");
            
            // Realiza e imprime el resultado de la comparación de igualdad
            Console.WriteLine($"{num1} == {num2} = {num1 == num2}");

            // Realiza e imprime el resultado de la operación lógica AND
            Console.WriteLine($"({num1} > 10 && {num2} > 10) = {(num1 > 10 && num2 > 10)}");
            
            // Realiza e imprime el resultado de la operación lógica OR
            Console.WriteLine($"({num1} > 10 || {num2} > 10) = {(num1 > 10 || num2 > 10)}\n");
        }
    }
}