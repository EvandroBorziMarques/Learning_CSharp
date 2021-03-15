using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            // character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            /*In this example, you can insert the number in type char, the number is transform for the
            table ASCII*/
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            //This example, the number of table ASCII plus 1.
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            Console.WriteLine(titulo);

            /*Type string create list, when you take the "@" in inicial of string, you can broke
            the line in one string*/
            string cursosProgramacao =
@" - .NET
 - JAVA
 - JavaScript";

            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();

        }
    }
}
