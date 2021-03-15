using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // The type int is a variable with support values until 32 bits.
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            // The type long is a variable with support values until 64 bits.
            long idade = 13000000000;
            Console.WriteLine(idade);

            // The type short is a variable with support values until 16 bits.
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            //Example the type float
            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.ReadLine();

        }
    }
}
