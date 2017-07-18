using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.2 - Added public abstract method DisplaySkills
 */
namespace COMP123_S2017_L10
{
    public abstract class Human
    {
        // PRIVATE PROPERTIES (FIELDS)
        private string _name;

        // PUBLIC PROPERTIES
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        //CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the Human class.
        /// It takes one parameter - name(string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }

        //PRIVATE METHODS

        //PUBLIC ABSTRACT METHODS
        public abstract void DisplaySkills();
    }
}