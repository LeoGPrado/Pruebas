using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Menu
    {
        private List<Scene> scenes;

        public void Execute()
        {
            scenes = new List<Scene>
            {
                new Valley(),
                new Desert(),
                new Castle()
            };

            foreach (Scene scene in scenes)
            {
                Console.Clear();
                scene.Play();
            }

            Console.WriteLine("Fin de la aventura");
            Console.ReadLine();
        }
    }
}