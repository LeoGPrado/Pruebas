using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Valley : Scene
    {
        public Valley() : base("Te encuentras en un valle misterioso rodeado de montañas.")
        {
        }
        public override void Play()
        {
            Console.WriteLine(description);
            Console.WriteLine("1: Explorar");
            Console.WriteLine("2: Salir corriendo");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Encuentras un camino misterioso...");
            }
            else
            {
                Console.WriteLine("Huyes del bosque asustado.");
            }

            Console.ReadLine();
        }
    }
}
