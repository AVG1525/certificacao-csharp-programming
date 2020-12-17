using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            bool possui_saldo = true;

            Console.WriteLine($"Possue Saldo: {possui_saldo}");

            int dias = DateTime.Now.Day;
            Console.WriteLine($"Dias: {dias}");

            bool dias_par = (dias % 2 == 0);
            if(dias_par)
                Console.WriteLine("Dias é um número par");
            else
                Console.WriteLine("Dias é um número impar");
        }
    }
}
