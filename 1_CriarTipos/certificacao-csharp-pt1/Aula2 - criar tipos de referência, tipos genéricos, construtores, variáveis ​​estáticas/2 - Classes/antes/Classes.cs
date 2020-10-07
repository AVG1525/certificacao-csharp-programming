﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Classes : IAulaItem
    {
        public void Executar()
        {
            ClassePosicaoGPS posicao1 = new ClassePosicaoGPS() 
            { Latitude = 13.78, Longitude = 29.51 };

            posicao1 = new ClassePosicaoGPS(13.78, 29.51);
            Console.WriteLine();
            Console.WriteLine(posicao1);

            PosicaoGPSComLeitura posicao2 = new PosicaoGPSComLeitura(13.78, 29.51, DateTime.Now);
            Console.WriteLine();
            Console.WriteLine(posicao2);
        }
    }

    public class ClassePosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public ClassePosicaoGPS()
        {

        }
        public ClassePosicaoGPS(double latitude, double longitude)
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

    public class PosicaoGPSComLeitura : ClassePosicaoGPS
    {
        private readonly DateTime DataLeitura;

        public PosicaoGPSComLeitura(double latitude, double longitude, DateTime dataLeitura) : base(latitude, longitude)
        {
            DataLeitura = dataLeitura;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude} e DataLeitura: {DataLeitura}";
        }
    }
}
