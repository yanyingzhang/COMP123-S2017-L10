﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Yanying Zhang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.5 - Add superVillain object and display it by using ToString method in the SuperHuman class
 */
namespace COMP123_S2017_L10
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            superHero.AddPower("Phasing", 30);
            superHero.AddPower("Invisibility", 25);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: " + superHero.Karma);
            Console.WriteLine();

            SuperVillain superVillain = new SuperVillain("BadFlash", 10);
            superVillain.AddPower("Change Time", 10);
            superVillain.AddPower("Run fast", 19);
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine("Villain: " + superVillain.Malice);
            Console.WriteLine();

            //if (superHero is SuperHero)
            //{
            //    Console.WriteLine("SuperHero is a superHero");
            //}
            //if (superHero is SuperHuman)
            //{
            //    Console.WriteLine("SuperHero is a superHuman");
            //}
            //if (superHero is Human)
            //{
            //    Console.WriteLine("SuperHero is a Human");
            //}
            //if (superHero is object)
            //{
            //    Console.WriteLine("SuperHero is an object");
            //}
            //if (superHero is IHasKarma)
            //{
            //    Console.WriteLine("SuperHero is a IHasKarma");
            //}
            //if (superHero is IHasMalice)
            //{
            //    Console.WriteLine("SuperHero is a IHasMalice");
            //}
        }
    }
}
