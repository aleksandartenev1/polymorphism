using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation;

namespace Polymorphism.MixtureDragons
{
    public class BoilDragon : Dragon
    {
        private bool success { get; set; }
        public KekkeiGenkai Mix { get; set; }
        public BoilDragon(string name, string element, int level) : base(name, element, level)
        {
            Mix = new KekkeiGenkai();
        }

        public string KekkeiGenkai(string firstElement, string secondElement)
        {
            if (firstElement == "water" && secondElement == "fire" || firstElement == "fire" && secondElement == "water")
            {
                success = true;
                return Mix.MixedDragon = "Boil Dragon";
            }
            else
            {
                success = false;
                return "undefined";
            }
        }

        public override void DragonScream()
        {
            if (success)
            {
                Console.WriteLine($"{Name} is a {Mix.MixedDragon} and blasts you with Boil Release: Melting Mist!");
            }
            else
            {
                Console.WriteLine($"{Name} is an undefined mixture and has undefined attack.");
            }

        }
    }
}
