using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;

            dynamic dinamico = 1;
            dinamico = dinamico + 3;

            Console.WriteLine(dinamico);

            dinamico.teste(); // dara erro em tempo dew execução.. a diferença dele pro object é que não verifica em tempo de compilação
        }
    }
}
