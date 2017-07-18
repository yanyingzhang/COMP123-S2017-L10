using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 13, 2017
 * Description: This is the SuperHero Class, which inherits from the SuperHuman clss and implemented 
 * Version: 0.3 - Modified constractor 
 */
namespace COMP123_S2017_L10
{
    /// <summary>
    /// This is the SuperHero class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        // private instance variables
        private int _karma;

        // public properties
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }
        // constractor

        /// <summary>
        /// This is the main constractor for the SuperHero class
        /// It takes one argument - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }
        // private methods

        // public methods

    }
}