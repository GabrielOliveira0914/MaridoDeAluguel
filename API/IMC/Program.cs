using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso;
            float altura;
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Digite seu peso em Kg: ");
            peso = float.Parse( Console.ReadLine());
            Console.WriteLine("Digite sua altura em Metros: ");
            altura = float.Parse(Console.ReadLine());
        }
    }
}
