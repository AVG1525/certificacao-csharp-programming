using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {
            string vendedorDefinido = "Maria Fatima";
            int numeroPedidoDefinido = 31;
            string nomeProdutoDefinido = "Caneca Preta";


            // Metodo chamado pelo jeito normal, usando argumentos posicionais
            ImprimirDetalhesDoPedido(vendedorDefinido, numeroPedidoDefinido, nomeProdutoDefinido);


            //Argumentos nomeados podem ser fornecidos para os parametros em qualquer ordem
            ImprimirDetalhesDoPedido(numeroPedido: numeroPedidoDefinido, nomeProduto: nomeProdutoDefinido, vendedor: vendedorDefinido);

            //Argumentos nomeados misturados com argumentos posicionais são válidos
            ImprimirDetalhesDoPedido(vendedorDefinido, numeroPedidoDefinido, nomeProduto: nomeProdutoDefinido);
        }

        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrWhiteSpace(vendedor))
            {
                throw new ArgumentException(message: "Nome de vendedor não pode ser nulo ou vazio.", paramName: nameof(vendedor));
            }

            Console.WriteLine($"Vendedor: {vendedor}, Pedido No.: {numeroPedido}, Produto: {nomeProduto}");
        }
    }
}
