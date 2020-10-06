using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade = 30;

            Console.WriteLine(idade);

            int copia_idade = idade;

            Console.WriteLine($"idade: {idade} - copia idade {copia_idade}");

            idade = 23;

            Console.WriteLine($"idade: {idade} - copia idade {copia_idade}");

            int? idade2 = null;
            System.Nullable<int> idade3 = null;
        }
    }
}
