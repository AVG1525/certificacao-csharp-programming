using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            //VOLUME DO CUBO = lado ^ 3;
            int lado = 3;

            Console.WriteLine();
            //Console.WriteLine($"Volume do cubo: {volumeCubo(lado)}");
            Console.WriteLine($"Volume do cubo: {volume(lado)}");

            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;

            Console.WriteLine();
            //Console.WriteLine($"Volume do cilindro: {volumeCilindro(altura, raio)}");
            Console.WriteLine($"Volume do cubo: {volume(altura, raio)}");

            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;

            Console.WriteLine();
            //Console.WriteLine($"Volume do prisma: {volumePrisma(largura, altura, profundidade)}");
            Console.WriteLine($"Volume do prisma: {volume(largura, altura, profundidade)}");
        }

        public double volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        public double volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        public double volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }
    }
}
