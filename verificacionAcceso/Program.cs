using System;

class Program3
{
    static void Main()
    {
        string usuarioCorrecto = "admin";
        string contraseñaCorrecta = "1234";

        Console.Write("Ingrese su nombre de usuario: ");
        string usuario = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contraseña = Console.ReadLine();

        if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
        {
            Console.WriteLine("Acceso concedido");
        }
        else if (usuario == usuarioCorrecto)
        {
            Console.WriteLine("Contraseña incorrecta");
        }
        else
        {
            Console.WriteLine("Usuario no registrado");
        }
    }
}