using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Scene
    {
        protected string description;

        public Scene(string description)
        {
            this.description = description;
        }

        public virtual void Play()
        {
            Console.WriteLine(description);
        }
    }
}