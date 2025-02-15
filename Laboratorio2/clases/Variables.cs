using System; // Métodos básicos para entrada y salida de datos
using System.Collections.Generic; // Permite trabajar con listas y diccionarios
using System.Linq; // Manipulación y consultas de datos en colecciones
using System.Text; // Permite manipular cadenas de texto con mayor flexibilidad
using System.Threading.Tasks; // Permite manejar tareas en paralelo y programación asincrónica

namespace TPG1 // Definimos un espacio de nombres llamado "TPG1" para organizar nuestro código
{

    class Variables // Declaramos una clase llamada "Variables" dentro del namespace "TPG1"

    {
        public static void CapturarYMostrar() // Método estático que captura y muestra diferentes tipos de variables


        {   // Solicita un número entero al usuario y lo almacena en la variable 'entero'
            Console.Write("Ingrese un número entero: ");
            int entero = int.Parse(Console.ReadLine());// Convierte la entrada de texto a un entero


            Console.Write("Ingrese un número decimal: ");
            double decimalNum = double.Parse(Console.ReadLine());// Convierte la entrada de texto a un número decimal


            Console.Write("Ingrese un texto: ");
            string texto = Console.ReadLine();// Captura el texto ingresado


            // Solicita un valor booleano (true o false) y lo almacena en la variable 'booleano'
            Console.Write("Ingrese un valor verdadero o falso (true/false): ");
            bool booleano = bool.Parse(Console.ReadLine());// Convierte la entrada a un valor booleano


            // Muestra los valores ingresados en la consola
            Console.WriteLine("\nValores ingresados:");
            Console.WriteLine($"Entero: {entero}");
            Console.WriteLine($"Decimal: {decimalNum}");
            Console.WriteLine($"Texto: {texto}");
            Console.WriteLine($"Booleano: {booleano}\n");
        }
    }
}

