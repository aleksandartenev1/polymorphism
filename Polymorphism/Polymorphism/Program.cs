using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var airDrake = new AirDragon("Windster", "air", 62);
            var fireDrake = new FireDragon("Blazor", "fire", 22);
            var waterDrake = new WaterDragon("Mizunsin", "water", 32);
            var earthDrake = new EarthDragon("Mountaineer", "earth", 34);
            var boilDrake = new MixtureDragons.BoilDragon("Booilster", "water", 1200);
            boilDrake.KekkeiGenkai(boilDrake.Core.Element, "fire");
            var magnetDrake = new MixtureDragons.MagnetDragon("Southster", "air", 120);
            magnetDrake.KekkeiGenkai(magnetDrake.Core.Element, "earth");
            var iceDrake = new MixtureDragons.IceDragon("Iccy", "air", 123123);
            iceDrake.KekkeiGenkai(iceDrake.Core.Element, "water");
            var lavaDrake = new MixtureDragons.LavaDragon("Lavoon", "fire", 1232123);
            lavaDrake.KekkeiGenkai(lavaDrake.Core.Element, "earth");

            List<Dragon> basicDragons = new List<Dragon>(4)
            {
                airDrake,
                fireDrake,
                waterDrake,
                earthDrake
            };

            List<Dragon> mixedDragons = new List<Dragon>(4)
            {
                boilDrake,
                magnetDrake,
                iceDrake,
                lavaDrake
            };

            foreach (var basic in basicDragons)
            {
                basic.DragonScream();
                Console.WriteLine();
            }

            foreach (var basic in mixedDragons)
            {
                basic.DragonScream();
                Console.WriteLine();
            }
        }
    }
}