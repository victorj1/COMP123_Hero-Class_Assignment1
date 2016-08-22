using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Author: Victor Jdanovitch
 * Student #: 300869472
 * Date Created: June 4th, 2016
 * Date Modified: August 21, 2016
 * Program Description: Assignment #1: Building and Implementing a Hero Class in Visual Studio
 * Revision: B - Final  
 */

namespace COMP123_Hero_Class_Assignment1
{
    /**
     * This class is the "Driver" class for the program
     * 
     * @class Program
     */ 
    class Program
    {
        /**
         * the main method for the driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        static void Main(string[] args)
        {

            // Creates a new instance of the Hero class

            Hero victor = new Hero("Victor");
            victor.Show();
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
            victor.Fight();
            

        }
    }
}
