﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation;

namespace Polymorphism.MixtureDragons
{
    public class MagnetDragon : Dragon
    {
        private bool success { get; set; }
        private string Mixture { get; set; }
        public KekkeiGenkai Mix { get; set; }
        public MagnetDragon(string name, string element, int level) : base(name, element, level)
        {
            Mix = new KekkeiGenkai();
        }

        public string KekkeiGenkai(string firstElement, string secondElement)
        {
            if (firstElement == "air" && secondElement == "earth" || firstElement == "earth" && secondElement == "air")
            {
                Mixture = "Magnet Dragon";
                success = true;
                return Mixture;
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
                Console.WriteLine($"{Name} is a {Mixture} and blasts you with Magnet Release: Gold Dust Imperial Funeral!");
            }
            else
            {
                Console.WriteLine($"{Name} is an undefined mixture and has undefined attack.");
            }

        }
    }
}
