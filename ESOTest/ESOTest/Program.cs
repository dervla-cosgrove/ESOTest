using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace ESOTest
{
    class Program
    {

        static void Main(string[] args)
        {
            //declaring vairbales
            string line, u_name;
            Boolean validDate = false;
            
            
            //header
            Console.WriteLine("FIRE HOUSE SCHEDULE ");
            
            //asking for user input
            Console.WriteLine("\nName: ");
            u_name = Console.ReadLine();

            //validating the date format 
            while(!validDate)
            {
                Console.WriteLine("\nPlease enter date in format dd/mm/yyyy");
                string dInput = Console.ReadLine();
                validDate = validation(dInput);

                try
                {
                    using (StreamReader sr = new StreamReader(@"D:\ESOTest\testing.txt"))
                    {
                        string task = sr.ReadToEnd();
                        Console.WriteLine(task);
                        
                    }
                }//try
                catch (Exception err)
                {
                    Console.WriteLine("Error: file unable to load");
                    Console.WriteLine(err.Message);
                }//catch

            }//validdate

            
        }//main

        //creating a new class and calling it in the main method
        //this class will validate the date the user has inputted 
        public static bool validation(string date)
        {
            try
            {
                DateTime.ParseExact(date, "dd/mm/yyyy", DateTimeFormatInfo.InvariantInfo);
                Console.WriteLine("Date valid");
                Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("Date invalid");
                return false;
            }
            return true;
            Console.ReadKey();
        }//boolean

        struct recurrTask
        {
            int id;
            string description, assignedTo;
            DateTime startDate;
            string frequency;
        }




    }//class
}//namespace
