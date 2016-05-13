//class#2: practice to perform how to do unit test and Github publish.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author:Christopher Ritchil 
 * Date: May 13, 2016
 * Date Modified: 
 * Student ID: 
 * 
 * Description: This program demonstrates Github and version control
 * 
 * Version: 0.2 - Added GetUserName method
 */
namespace comp123_s2016_lesson1B
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserName(); 
        }

        /**
         * This method reads the UserName from the Console
         * 
         * @method GetUserNmae
         * @return {string} UserName
         */
        public static string GetUserName()
        {
            //Initializa variables
            string userName = "";
            Console.Write("Enter UserName: ");
            userName = Console.ReadLine();

            Console.WriteLine("/n=========================");
            Console.WriteLine("You Entered: " + userName);

            return userName; 
        }
    }
}
