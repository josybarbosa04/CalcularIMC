using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine("*CALCULADORA DE IMC*");

            Console.WriteLine("Digite seu peso: ");
            calculadora.Peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(calculadora.Peso);

            Console.WriteLine("Digite sua altura: ");
            calculadora.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(calculadora.Altura);

            Console.WriteLine("O seu IMC é:" + calculadora.Imc);
            Console.WriteLine(calculadora.Classificacao);

            Console.ReadKey();
        }
    }
}
