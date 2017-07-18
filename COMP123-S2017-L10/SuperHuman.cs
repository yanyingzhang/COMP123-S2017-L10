using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.7 - Added GetPower method for SuperHuman class
 */
namespace COMP123_S2017_L10
{
    /// <summary>
    /// This is the SuperHuman class.
    /// </summary>
    public class SuperHuman : Human
    {
        //PRIVATE INSTANCE VARIALES
        private List<Power> _prowers;

        //PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._prowers; // this returns a reference
            }
        }

        //CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperHuman class.
        /// It takes one parameter - name(string).
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }
        //PRIVATE METHODS

        /// This method initializes, instantiates and assigns values to class
        private void _initialize()
        {
            this._prowers = new List<Power>(); // creates an empty list
        }

        /// <summary>
        /// This private method returns the index of the power name in the power list
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private int _getPowerIndex(string name)
        {
            int index = 0;
            foreach(Power power in this.Powers)
            {
                if (name.Equals(power.Name))
                {
                    break;
                }
                index++;

                if(this.Powers.Count == index)
                {
                    index = -1; //this means that we did not find the power in the list
                }
            }
            return index;
        }

        //PUBLIC METHODS

        /// <summary>
        /// This metod adds a power to the Power list.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        /// <summary>
        /// This method diaplays each f the Powers stored in the Powers list
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + "; Rank: " + power.Rank);
            }
        }
        // PUBLIC OVERRIDDEN METHOD

        /// <summary>
        /// Overridden the built-in 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "====================================\n";
            outputString += "SuperHuman Name: " + this.Name + "\n";
            outputString += "====================================\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + "; Rank: " + power.Rank + "\n";
            }

            return outputString;
        }

        /// <summary>
        /// This is the DisplaySkills Method
        /// Needs to be implemented...
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented!");
        }

        /// <summary>
        /// This method returns a Power object that matches the power class
        /// If the power is not found it returns the anonymous power
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Power GetPower(string name)
        {
            int index = this._getPowerIndex(name);
            if (index != -1)
            {
                return this.Powers[index];
            }
            return new Power("Unknown Power", 0);
        }
    }
}