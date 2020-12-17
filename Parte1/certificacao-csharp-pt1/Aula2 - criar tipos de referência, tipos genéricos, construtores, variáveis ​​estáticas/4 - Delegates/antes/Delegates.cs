using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    /*
    Delegates podem ser armazenados como variáveis de referência, que representam e 
    apontam para um determinado método, e são muito usados em combinação com eventos.
    */
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    delegate double MetodoMultiplcacao(double input);

    class Calculadora
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }

        static double Triplicar(double input)
        {
            return input * 3;
        }

        public static void Executar()
        {

            //Executa diretamente o método
            Console.WriteLine();
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

            //Executa diretamente o método
            Console.WriteLine();
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

            MetodoMultiplcacao metodoMultiplcacao = Duplicar;
            Console.WriteLine();
            Console.WriteLine($"Duplicar: {metodoMultiplcacao(7.5)}");

            metodoMultiplcacao = Triplicar;
            Console.WriteLine();
            Console.WriteLine($"Triplicar: {metodoMultiplcacao(7.5)}");

            //instancia de um delegado com um metodo anonimo
            MetodoMultiplcacao metodoQuadrado = delegate (double input)
            {
                return input * input;
            };

            double quadrado = metodoQuadrado(5);
            Console.WriteLine();
            Console.WriteLine($"Quadrado: {quadrado}");


            //instancia de um delegado com uma expressao lambda
            MetodoMultiplcacao metodoCubo = input => input * input * input;
            double cubo = metodoCubo(4.375);
            Console.WriteLine();
            Console.WriteLine($"Cubo: {cubo}");
        }
    }
}
