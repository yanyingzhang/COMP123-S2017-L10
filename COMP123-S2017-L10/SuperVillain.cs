using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 13, 2017
 * Description: This is the SuperVillain subclass of the SuperHuman base class 
 * Version: 0.2 - Modified SuperVillain class
 */
namespace COMP123_S2017_L10
{
    /// <summary>
    /// This SuperVillain class is a subclass of SuperHuman
    /// It implements the IHasMalic Interface
    /// </summary>
    public class SuperVillain : SuperHuman, IHasMalice
    {
        // PRIVATE PROPERTIES
        private int _malice;
        // PUBLIC PROPERTIES
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
        // CONSTRACTOR
        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }
        // PRIVATE METHODS
        // PUBLIC METHODS
    }
}