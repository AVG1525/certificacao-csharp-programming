using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            Impressora impressora = new Impressora("Este é\r\no meu documento");
            impressora.ImprimirDocumento();

            ImprimirDocumentoHTML(impressora.Documento);

            impressora.ImprimirDocumentoHTML();
        }

        void ImprimirDocumentoHTML(string documento)
        {
            Console.WriteLine();
            Console.WriteLine($"<html><body>{documento}</body></html>");
        }
    }

    class Impressora
    {
        public string Documento { get; }

        public Impressora(string documento)
        {
            this.Documento = documento;
        }

        public void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }
        //public void ImprimirDocumentoHTML()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine($"<html><body>{Documento}</body></html>");
        //}
    }

    static class impressoraExtensions
    {
        //A palavra reservada this representa que esse metodo é uma extensão da classe Impressora
        public static void ImprimirDocumentoHTML(this Impressora impressora)
        {
            Console.WriteLine();
            Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }
    }
}


