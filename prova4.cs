using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string[] palavras = frase.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);


        Console.WriteLine($"A quantidade de palavras na frase é: {palavras.Length}");
    }
}
