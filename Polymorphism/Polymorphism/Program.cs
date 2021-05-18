using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var airDrake = new AirDragon("Windster", "air", 120);
            airDrake.DragonScream();

            Console.WriteLine();

            var fireDrake = new FireDragon("Blazor", "fire", 1220);
            fireDrake.DragonScream();

            Console.WriteLine();

            var waterDrake = new WaterDragon("Mizunsin", "water", 1320);
            waterDrake.DragonScream();

            Console.WriteLine();

            var boilDrake = new MixtureDragons.BoilDragon("Mountainster", "water", 1200);
            boilDrake.KekkeiGenkai(boilDrake.Core.Element, "fire");
            boilDrake.DragonScream();

            Console.WriteLine();

            var magnetDrake = new MixtureDragons.MagnetDragon("Windster", "air", 120);
            magnetDrake.KekkeiGenkai(magnetDrake.Core.Element, "earth");
            magnetDrake.DragonScream();

            Console.WriteLine();

            var iceDrake = new MixtureDragons.IceDragon("MEow", "air", 123123);
            iceDrake.KekkeiGenkai(iceDrake.Core.Element, "earth");
            iceDrake.DragonScream();

            Console.WriteLine();

            var lavaDrake = new MixtureDragons.LavaDragon("Lavoon", "fire", 1232123);
            lavaDrake.KekkeiGenkai(lavaDrake.Core.Element, "earth");
            lavaDrake.DragonScream();

        }
    }
}