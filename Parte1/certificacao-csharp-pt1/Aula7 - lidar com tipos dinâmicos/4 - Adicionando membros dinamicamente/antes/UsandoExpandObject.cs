﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class UsandoExpandObject : IAulaItem
    {
        public void Executar()
        {
            string json = "{\"De\": \"Paulo Silveira\"," +
                "\"Para\": \"Guilherme Silveira\"}";

            dynamic msg = JsonConvert.DeserializeObject<ExpandoObject>(json);

            msg.Texto = "Olá, " + msg.Para;

            EnviarMensagem(msg);

            msg.Inverter = new Action(() => 
            {
                var aux = msg.De;
                msg.De = msg.Para;
                msg.Para = aux;
                msg.Texto = "Olá, " + msg.Para;
            });

            msg.Inverter();
            EnviarMensagem(msg);
        }

        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }

    //class Mensagem
    //{
    //    public string De { get; set; }
    //    public string Para { get; set; }
    //    public string Texto { get; set; }
    //}
}
