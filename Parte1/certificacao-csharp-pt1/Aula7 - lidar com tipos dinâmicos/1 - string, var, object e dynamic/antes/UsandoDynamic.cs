using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            // tipo é definido em tempo de compilação
            string s = "Certificação c#";
            // tipo é definido em tempo de compilação (por inferencia)
            var v = "Certificação c#";

            // tipo é definido em tempo de compilação
            object o = "Certificação c#";

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);


            o = 123;
            o = (int)o + 4;
            Console.WriteLine(o);

            // tempo é definido em tempo de execução
            dynamic d = "Certificação c#";
            Console.WriteLine(d);

            d = d.ToUpper();
            Console.WriteLine(d);

            d = 123;
            Console.WriteLine(d);

            d = d + 4;
            Console.WriteLine(d);
        }
    }
}
