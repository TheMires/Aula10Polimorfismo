using CalculoFormas.src;
using System;

namespace CalculoFormas
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            Console.Write("Informe a altura: ");
            quadrado.Lado = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a Largura: ");
            quadrado.Lado = Convert.ToDouble(Console.ReadLine());


            Retangulo retangulo = new Retangulo();
            Triangulo triangulo = new Triangulo();



        }
    }
}
