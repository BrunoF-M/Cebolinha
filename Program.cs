using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string texto;

Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Olá, eu sou o Cebolinha.. \nE vou lepetir tudo que você Escleve aqui: ");
Console.ResetColor();
            texto = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.DarkGreen;

            string textocbl = texto.Replace("r" , "l").Replace("R" , "L");
            Console.WriteLine(""); //espaço
            Console.WriteLine($" {textocbl}");
Console.ResetColor();
            Console.WriteLine(""); //espaço
            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
Console.ResetColor();
            Console.Clear();
        }
    }
}
