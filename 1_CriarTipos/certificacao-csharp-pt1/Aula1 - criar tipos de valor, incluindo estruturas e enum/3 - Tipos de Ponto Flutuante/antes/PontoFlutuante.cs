using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            float idade = 15;
            idade = 15.5f;

            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");


            float massa_da_terra = 5.9736e24f; //System.Single -> tipo do dotnet que no csharp chamo de float porém ele tem uma simples precisao
            Console.WriteLine($"Massa da Terra: {massa_da_terra}");

            float numero_pi = 3.14159f; //System.Single

            double numero_muito_maior = 6e100;

            Console.WriteLine();
            Console.WriteLine("Operação com int, float, e short");

            int x = 3; //System.Int32
            short y = 5; //System.Int16

            var resultado1 = x * y; //System.Int32 -> quando se opera com tipos diferentes ele atrubui o resultado em resultado1 com a repesentação do maior tipo operado
            Console.WriteLine($"x * y = {resultado1}");
            Console.WriteLine($"O resultado é do tipo {resultado1.GetType()}");

            float z = 4.5f;

            var resultado2 = (x * y) / z;
            
            Console.WriteLine($"(x * y) / z = {resultado2}");
            Console.WriteLine($"O resultado é do tipo {resultado2.GetType()}");

        }
    }
}
