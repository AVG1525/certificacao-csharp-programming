using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");

            Console.WriteLine();
            Console.WriteLine("OBJECT COM VALOR PRIMITOVO");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"Meu objeto: {meuObjeto}");
            Console.WriteLine($"MeuObjeto.GetType(): {meuObjeto.GetType()}");
            
            Console.WriteLine();
            Console.WriteLine("OBJECT COM REFERENCIA DE OBJETO");

            meuObjeto = new Jogador();
            Jogador classRef;
            classRef = (Jogador)meuObjeto; //conevrsão explícita ou "cast"

            Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
