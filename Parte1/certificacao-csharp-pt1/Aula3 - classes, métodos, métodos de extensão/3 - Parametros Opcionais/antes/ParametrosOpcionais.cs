using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas");
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial.FazerPedido(2, "Comercial");

            clienteEspecial.FazerPedido(3);

            clienteEspecial.FazerPedido(3, quantidade: 4);
        }
    }

    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome = "Matheus")
        {
            this.nome = nome;
        }

        //Os parametros opcionais devem aparecer por último para não darem erro de compilação
        public void FazerPedido(int produtoId, string endereco = "Residencial", int quantidade = 10)
        {
            Console.WriteLine("cliente {0}: produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
        }
    }
}
