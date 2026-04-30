using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Castle : Scene
    {
        public Castle() : base("Te encuentras frente a un castillo antiguo y misterioso.")
        {
        }
        public override void Play()
        {
            Console.WriteLine(description);
            Console.WriteLine("1: Entrar al castillo");
            Console.WriteLine("2: Rodear el castillo");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Dentro del castillo encuentras un tesoro escondido... tan escondido que nunca lo llegaste a encontrar del todo. FIN");
            }
            else
            {
                Console.WriteLine("Decides dar la vuelta y retirarte de tu misión.");
            }
            Console.ReadLine();
        }
    }
}
