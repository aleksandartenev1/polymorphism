using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation;

namespace Polymorphism.MixtureDragons
{
    class IceDragon : Dragon
    {
        private bool success { get; set; }
        public KekkeiGenkai Mix { get; set; }
        public IceDragon(string name, string element, int level) : base(name, element, level)
        {
            Mix = new KekkeiGenkai();
        }

        public string KekkeiGenkai(string firstElement, string secondElement)
        {
            if (firstElement == "air" && secondElement == "water" || firstElement == "water" && secondElement == "air")
            {
                success = true;
                return Mix.MixedDragon = "Ice Dragon";
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
                Console.WriteLine($"{Name} is a {Mix.MixedDragon} and blasts you with Ice Release: One Horned White Whale!");
            }
            else
            {
                Console.WriteLine($"{Name} is an undefined mixture and has undefined attack.");
            }
        }
    }
}
