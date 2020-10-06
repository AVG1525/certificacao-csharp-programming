using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5;

            char resposta = 'S'; // System.Char

            byte nivel_de_azul = 0xFF; // = 255 em decimal

            short passageiros_voo = 230; // System.Int16
            passageiros_voo = -7;

            int populacao = 1500; // System.Int32
            populacao = -2300;

            long populacao_do_brasil = 207_660_929; // +/- 207 milhoes - System.Int64

            sbyte nivel_de_brilho = -127; // System.Sbyte -> permite "byte" com numero negativos

            ushort passageiros_navio = 230; //System.UInt16 -> unsigned, ele não armazena o bit do sinal (+ ou -)

            uint estoque = 1500; // System.UInt32 -> unsigned, ele não armazena o bit do sinal

            ulong populacao_do_mundo = 7_000_000_000; // 7 bilhoes - System.UInt64
        }
    }
}
