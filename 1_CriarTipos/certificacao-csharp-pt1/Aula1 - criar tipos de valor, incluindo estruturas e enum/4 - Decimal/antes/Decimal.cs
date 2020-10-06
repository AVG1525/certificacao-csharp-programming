using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valor_produto1 = 10;
            double valor_produto2 = 20;
            double subtotal = 30;

            Console.WriteLine("Descobrindo se 10 + 20 == 30");
            Console.WriteLine((valor_produto1 + valor_produto2) == subtotal);

            valor_produto1 = 10.10;
            valor_produto2 = 20.20;
            subtotal = 30.30;
            Console.WriteLine();         
            Console.WriteLine("Descobrindo se 10.10 + 20.20 == 30.30");
            Console.WriteLine((valor_produto1 + valor_produto2) == subtotal); // para operacões dessa forma ele da false pq não arredonda a adição (ele funciona realizando operações binarias)
            Console.WriteLine(valor_produto1 + valor_produto2); // agr se eu não fizer a comparacao ele daria certo

            decimal materia_prima = 10.1m; // System.Decimal
            decimal mao_de_obra = 20.2m; // System.Decimal
            decimal custo = 30.3m; // System.Decimal


            Console.WriteLine();
            Console.WriteLine("Descobrindo se (10.1m + 20.2m) == 30.3m");
            Console.WriteLine((materia_prima + mao_de_obra) == custo); // ele funciona não como um binario mas como um decimal
        }
    }
}
