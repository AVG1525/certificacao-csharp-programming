using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class PropriedadesIndexadas : IAulaItem
    {
        public void Executar()
        {
            var sala = new Sala();
            //Forma Normal
            //sala.SetReserva("D01", new ClienteCinema("Maria de Souza"));
            //sala.SetReserva("D02", new ClienteCinema("José da Silva"));

            //Forma utilizando as propriedades indexadas
            sala["D01"] =  new ClienteCinema("Maria de Souza");
            sala["D02"] = new ClienteCinema("José da Silva");

            sala.ImprimirReservas();
        }
    }

    class ClienteCinema
    {
        public ClienteCinema(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }

    class Sala
    {
        public ClienteCinema this [string codigoAssento] {  //Propriedades Indexadas
            get {
                return reservas[codigoAssento];
            } 
            
            set {
                reservas[codigoAssento] = value;
            } 
        }

        private readonly IDictionary<string, ClienteCinema> reservas
            = new Dictionary<string, ClienteCinema>();

        //Forma normal
        //public ClienteCinema GetReserva(string codigoAssento)
        //{
        //    return reservas[codigoAssento];
        //}

        //public void SetReserva(string codigoAssento, ClienteCinema value)
        //{
        //    reservas[codigoAssento] = value;
        //}

        public void ImprimirReservas()
        {
            Console.WriteLine("Assentos Reservados");
            Console.WriteLine("===================");
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"{reserva.Key} - {reserva.Value}");
            }
        }
    }
}
