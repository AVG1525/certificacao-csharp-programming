using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Strings : IAulaItem
    {
        public void Executar()
        {
            string a = "bom dia"; //System.String -> é um tipo de referencia
            string b = "b";

            b += "om dia";
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine();
            // Verificando se contendo o mesmo texto as duas variaveis string apontam pro mesmo endereco na memoria
            Console.WriteLine($"(object)a == (object)b: {(object)a == (object)b}");

            string bomDia = "Bom dia";
            Console.WriteLine();
            Console.WriteLine($"bomDia[4]: {bomDia[4]}");

            var caractere = bomDia[4];
            Console.WriteLine();
            Console.WriteLine($"caractere.GetType(): {caractere.GetType()}"); // Resultado -> System.Char
        }
    }
}
