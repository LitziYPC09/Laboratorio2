using System; // Proporciona clases y métodos básicos, como Console para entrada y salida de datos
using System.Collections.Generic; // Permite trabajar con colecciones genéricas como listas y diccionarios
using System.Linq; // Proporciona funcionalidades para manipulación y consultas de datos en colecciones
using System.Text; // Permite manipular cadenas de texto con mayor flexibilidad
using System.Threading.Tasks; // Permite manejar tareas en paralelo y programación asincrónica

namespace TPG1
{
    // Definición de la clase OperacionesMatematicas
    class OperacionesMatematicas
    {
        // Método estático que realiza operaciones matemáticas
        public static void RealizarOperaciones()
        {
            // Solicita al usuario que ingrese el primer número entero y lo convierte a entero
            Console.Write("Ingrese el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());
            
            // Solicita al usuario que ingrese el segundo número entero y lo convierte a entero
            Console.Write("Ingrese el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            // Realiza e imprime el resultado de las operaciones matemáticas
            Console.WriteLine("\nOperaciones Matemáticas (Enteros):");
            Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
            
            // Resultado de la división de enteros, manejando la división por cero
            Console.WriteLine($"División: {num1} / {num2} = {(num2 != 0 ? (double)num1 / num2 : 0)}\n");

            // Solicita al usuario que ingrese un número decimal y lo convierte a float
            Console.Write("Ingrese un número decimal: ");
            float numFloat = float.Parse(Console.ReadLine());
            Console.Write("Ingrese otro número decimal: ");
            float numFloat2 = float.Parse(Console.ReadLine());

             // Realiza e imprime el resultado de las operaciones matemáticas con decimales (float)
            Console.WriteLine("\nOperaciones Matemáticas (Decimales - Float):");
            Console.WriteLine($"Suma: {numFloat} + {numFloat2} = {numFloat + numFloat2}");
            Console.WriteLine($"Resta: {numFloat} - {numFloat2} = {numFloat - numFloat2}");
            Console.WriteLine($"Multiplicación: {numFloat} * {numFloat2} = {numFloat * numFloat2}");
            
            // Realiza e imprime el resultado de la división de decimales, manejando la división por cero
            Console.WriteLine($"División: {numFloat} / {numFloat2} = {(numFloat2 != 0 ? numFloat / numFloat2 : 0)}\n");
        }
    }
}