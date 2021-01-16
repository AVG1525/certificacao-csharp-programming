using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);
        }

        public void Alimentar(object obj)
        {
            //Animal animal = null;

            //if (obj is Animal) animal = (Animal)obj; // ou  (obj is IAnimal)

            /*Animal animal = obj as Animal;

            if (animal == null)
            {
                Console.WriteLine("obj não é um animal.");
                return;
            }

            animal.Beber();
            animal.Comer();*/

            if(obj is Animal animal)
            {
                animal.Beber();
                animal.Comer();
                return;
            }

            Console.WriteLine("obj não é um animal.");
        }
    }
}
