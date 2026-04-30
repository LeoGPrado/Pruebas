using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Desert : Scene
    {
        public Desert() : base("Te encuentras en un desierto caluroso interminables.")
        {
        }
        public override void Play()
        {
            Console.WriteLine(description);
            Console.WriteLine("1: Entrar");
            Console.WriteLine("2: Rodear la cueva");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Dentro hay un ruido extraño, si no fuera una tarea mas simple posiblemente encontrarias algo interesante, decides seguir tu camino.");
            }
            else
            {
                Console.WriteLine("Evitas la cueva y sigues tu camino.");
            }

            Console.ReadLine();
        }
    }
}
