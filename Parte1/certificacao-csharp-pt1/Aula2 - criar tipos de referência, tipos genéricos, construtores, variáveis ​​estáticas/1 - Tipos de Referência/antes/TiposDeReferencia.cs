using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            // TIPOS DE VALOR COM STRUCT
            int idade = 42;
            int copia_idade = idade;

            Console.WriteLine("int idade = 42");
            Console.WriteLine("int copia_idade = idade");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copia_idade: {copia_idade}");

            idade = 32;
            Console.WriteLine();
            Console.WriteLine("idade = 32");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copia_idade: {copia_idade}");

            var cli1Struct = new ClienteStruct("Jose", 18);
            var cli2Struct = cli1Struct;

            Console.WriteLine();
            Console.WriteLine(@"
                cl1Struct = new ClienteStruct(Jose, 18)
                cli2Struct = cli1Struct
            ");
            Console.WriteLine($"cli1Struct: {cli1Struct}");
            Console.WriteLine($"cli2Struct: {cli2Struct}");

            cli1Struct.Nome = "Maria";
            Console.WriteLine();
            Console.WriteLine("cli1Struct.Nome = Maria");
            Console.WriteLine($"cli1Struct: {cli1Struct}");
            Console.WriteLine($"cli2Struct: {cli2Struct}");
            // FIM TIPOS DE VALOR COM STRUCT
            // A PARTIR DAQUI É TIPOS DE REFERENCIA

            var cli1Class = new ClienteClass("Jose", 18);
            var cli2Class = cli1Class;

            Console.WriteLine();
            Console.WriteLine(@"
                cl1Class = new ClienteClass(Jose, 18)
                cli2Class = cli1Class
            ");
            Console.WriteLine($"cli1Class: {cli1Class}");
            Console.WriteLine($"cli2Class: {cli2Class}");

            cli1Class.Nome = "Maria";
            Console.WriteLine();
            Console.WriteLine("cli1Class.Nome = Maria");
            Console.WriteLine($"cli1Class: {cli1Class}");
            Console.WriteLine($"cli2Class: {cli2Class}");
        }
    }

    struct ClienteStruct // Struct é um tipo de valor, ou seja, quando eu troco o valor da variavel original a sua cópia não é afetada
    {
        public ClienteStruct(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} - Idade: {Idade}";
        }
    }

    class ClienteClass // Class é um tipo de referencia, ou seja, quando eu troco o valor da variavel original a sua cópia é afetada
    { //tipos de referencia são ponteiros apontando pra um determinado endereco na memoria então quando afeta um as copias tambem são afetadas
        public ClienteClass(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} - Idade: {Idade}";
        }
    }
}
