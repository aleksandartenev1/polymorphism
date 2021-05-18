using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation;

namespace Polymorphism
{
    public class Dragon
    {
        public CoreProp Core { get; set; }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Dragon(string name, string element, int level)
        {
            Name = name;
            Core = new CoreProp(element, level);
        }

        public virtual void DragonScream()
        {
            if (Core.Level >= 70)
            {
                Console.WriteLine($"Elder Dragon {Name} has {Core.Element} element and is level {Core.Level}.");
            }
            else
            {
                Console.WriteLine($"Elder Dragon {Name} has {Core.Element} element and is level {Core.Level}.");
            }
        }
    }
}