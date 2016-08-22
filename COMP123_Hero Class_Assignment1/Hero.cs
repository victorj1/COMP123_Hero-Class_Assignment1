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
    * This class defines a Hero
    *
    * @class Hero
    * @field _strength {int}
    * @field _speed {int}
    * @field _health {int}
    * @field _name {string}
    */

    public class Hero
    {

        // Create Private Instance Variables

        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        // PUBLIC PROPERTIES ----------------------------

        /**
         * <summary>
         * This is a public property for our private _name field
         * </summary>
         * 
         * @property {string} Name
         */
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

        
        public Hero(string name)
        {
            // Initialize public properties
            this.Name = name;
        }


        //PRIVATE METHODS ------------------------------------

        /**
         * <summary>
         * This method randomly generates the ability numbers for the strength, speed and health properties.
         * </summary>
         * 
         * @method _generateAbilities()
         * @return {void}
         */
        private void _generateAbilities()
        {
            Random abilities = new Random();
            _strength = abilities.Next(1, 101);
            _speed = abilities.Next(1, 101);
            _health = abilities.Next(1, 101);
        }

        /**
         * <summary>
         * This method randomly determines if the Hero hits (chance is 20%) or not.
         * </summary>
         * 
         * @method _ghitAttempt()
         * @return {bool}
         */
        private bool _hitAttempt()
        {
            Random hit = new Random();
            int prob = hit.Next(100);
            if (prob < 20)
                return true;
            else
                return false;
        }
        /**
         * <summary>
         * This method calculates the damage the Hero gives to the target if hit
         * </summary>
         * 
         * @method _hitDamage()
         * @return {int}
         */
        private int _hitDamage()
        {
            Random hitdamage = new Random();
            int damage;
            damage = _strength * hitdamage.Next(1, 7);
            return (damage);
        }

        //PUBLIC METHODS ---------------------------------------------
        /**
         * <summary>
         * This method calls the private hitAttempt method. If hitAttempt returns true, then it will call the private hitDamage method.
         * </summary>
         * 
         * @method Fight
         * @return {void}
         */

        public void Fight()
        {
            bool hit = _hitAttempt();
            if (hit == true)
            {
                Console.WriteLine("Hero inflicted {0} damage!",_hitDamage());
            }
            else
            {
                Console.WriteLine("You missed, no damage given.");
                Console.WriteLine("");
            }

        }
        /**
         * <summary>
         * This method shows the name of the hero and randomly chooses the values for hero's abilities. 
         * </summary>
         * 
         * @method Show
         * @return {void}
         */
        public void Show()
        {
            Console.WriteLine("       **********     ");
            Console.WriteLine("         " + this.Name);
            Console.WriteLine("       **********     ");
            Console.WriteLine("");
            _generateAbilities();
            Console.WriteLine("Hero Strength:     " + _strength);
            Console.WriteLine("Hero Speed:        " + _speed);
            Console.WriteLine("Hero Health:       " + _health);
        }
    }
}
