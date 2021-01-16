using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_123_456_789;
            long inteiroLongo = inteiro;

            Console.WriteLine(inteiroLongo);

            Gato gato = new Gato();
            Animal animal = gato;
            Console.WriteLine(animal.GetType());

            //IAnimal _animal = gato;
            //Console.WriteLine(_animal.GetType());
        }
    }
}

