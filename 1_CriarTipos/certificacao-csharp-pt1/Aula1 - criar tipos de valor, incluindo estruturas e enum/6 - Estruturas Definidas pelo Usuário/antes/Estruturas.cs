using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            PosicaoGPS posicao1;
            posicao1.Latitude = 13.78;
            posicao1.Longitude = 29.51;

            posicao1 = new PosicaoGPS(13.78, 29.51);
            Console.WriteLine();
            Console.WriteLine(posicao1);
        }
    }

    interface IGPS
    {
        bool EstaNoHemisferioNorte();
    }

    struct PosicaoGPS : IGPS //struct não suporte herança, só a interface mesmo
    { // structs são tipo de valor pq quando copiadas pra outra variavel as duas podem tomar caminhos diferentes... ja uma classe é por referencia
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude} e Longitude: {Longitude}";
        }
    }
}
