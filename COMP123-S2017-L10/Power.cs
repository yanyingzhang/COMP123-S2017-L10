using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.1 - Create the Power class
 */
namespace COMP123_S2017_L10
{
    /// <summary>
    /// This is the Power class, which will be used as a data type
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        //CONSTRUTORS

        /// <summary>
        /// This is the main constructor for the Power class.
        /// It takes two arguments - name(string), rank(int).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}