using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Yanying Zhang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.7 - Implement of AntiHero class
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

            AntiHero badman = new AntiHero("Badman", 20, 20);
            badman.AddPower("Super Intelligence",50);
            Console.WriteLine(badman.ToString());
            Console.WriteLine("Karma: " + badman.Malice);
            Console.WriteLine("Villain: " + badman.Karma);


            if (superVillain.GetPower("Run fast") >superVillain.GetPower("Change Time"))
            {
                Console.WriteLine("Run fast is more powerful");
            }
            if(superVillain.GetPower("Run fast") < superVillain.GetPower("Change Time"))
            {
                Console.WriteLine("Run fast is more powerful");
            }
            if (superVillain.GetPower("Run fast") == superVillain.GetPower("Change Time"))
            {
                Console.WriteLine("Run fast and change time are same powerful");
            }
            
        }
    }
}
