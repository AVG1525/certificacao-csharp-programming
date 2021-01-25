using System;
using System.Security.Cryptography;

namespace Topico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            //funcionario.salario = 1000;

            //Console.WriteLine(funcionario.salario);


            //funcionario.salario = -1200;
            //Console.WriteLine(funcionario.salario);

            funcionario.Salario = 1200;
            Console.WriteLine(funcionario.Salario);
        }
    }

    class Funcionario
    {
        decimal salario; //se nao definir ele cria implicitamente como private

        public decimal Salario // encapsulamento do campo salário
        {
            get
            {
                return salario;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("salario nao pode ser negativo");
                salario = value;
            }
        }
    }
}
