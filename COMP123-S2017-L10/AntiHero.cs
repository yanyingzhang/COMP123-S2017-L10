using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 20, 2017
 * Description: This is the AntiHero Class
 * Version: 0.1 - Create AntiHero Class
 */
namespace COMP123_S2017_L10
{
    public class AntiHero : SuperHuman, IHasKarma, IHasMalice
    {
        // private instance variables
        private int _karma;
        private int _malice;

        // public property
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

        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }
        // constructor
        /// <summary>
        /// This is the constructor for the AntiHero class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        /// <param name="malice"></param>
        public AntiHero(string name, int karma, int malice) : base(name)
        {
            this.Karma = karma;
            this.Malice = malice;
        }   

        // private method

        // public method
         
    }
}