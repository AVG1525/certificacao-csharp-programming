using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            DiasDaSemana primeiro_dia = DiasDaSemana.Seg;
            DiasDeTrabalho dias_de_trabalho = 
                DiasDeTrabalho.Ter | DiasDeTrabalho.Qui | DiasDeTrabalho.Sex;

            Console.WriteLine(dias_de_trabalho);
        }
    }

    enum DiasDaSemana : long
    { 
        Seg = 3,
        Ter,
        Qua,
        Qui,
        Sex,
        Sab,
        Dom
    }

    // se não colocar o flags ele vai me dar os valores de cada um como por exeplo Seg é 0. 
    // Quando tem o atributo ele me retorna o nome do valor selecionado, por exemplo se selecionei 0 então retorna Seg.
    [Flags] 
    enum DiasDeTrabalho
    {
        Seg = 0,
        Ter = 1,
        Qua = 2,
        Qui = 4,
        Sex = 8,
        Sab = 16,
        Dom = 32
    }
}
