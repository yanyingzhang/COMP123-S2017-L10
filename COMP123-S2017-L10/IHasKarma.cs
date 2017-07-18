using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 13, 2017
 * Description: This is an Interface that defines a Karma Property 
 *              that mst be implemented in any class that substribes to it.
 * Version: 0.1 - Created IHasKarma Interface
 */
namespace COMP123_S2017_L10
{
    /// <summary>
    /// This is the IHasKarma Interface
    /// </summary>
    public interface IHasKarma
    {
        // private instance variables - interface cannot contain fields!!!
        // private int _karma;  -- ERROR

        // public properties
        int Karma { get; set; }
    }
}