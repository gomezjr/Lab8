using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        public static string[] names = new string[100];
        public static string[] foods = new string[100];
        public static string[] towns = new string[100];



        


        static void Main(string[] args)
        {
            AddStudent("Tommy", "Raleigh", "Chicken Curry", 0);
            AddStudent("Callista", "Traverse City", "Crab Rangoon", 1);
            AddStudent("Miguel", "Chicago", "BBQ Ribbs", 2);
            AddStudent("Nathan", "Grand Rapids", " Burgers", 3);
            AddStudent("Brad", "Kentwood", "Sushi", 4);
            AddStudent("Lisa", "Sokcho, South Korea", "Fruit", 5);
            AddStudent("Steven", "Sudbury, Ontario", "Risotto", 6);
            AddStudent("Andre", "St Catherines, Ontario", "Veggie Burgers", 7);


            bool playAgain = true;
            while (playAgain == true)
            {
                GetInput();

                Console.WriteLine("Do you want to learn about another student? Y/N");
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    playAgain = true;
                    Console.WriteLine("");
                }
                if (input == "n")
                {
                    Console.WriteLine("Thanks for playing.");
                    playAgain = false;
                }

            }

            

            
            
            
            

        }

        public static void AddStudent(string name, string town, string food, int index)
        {
            names[index] = name;
            foods[index] = food;
            towns[index] = town;
        }

        public static string GetStudent(int index)
        {
            string output = $"{names[index]} {foods[index]} {towns[index]}";
            return output;

        }

        public static void PrintMenu()
        {
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                if (name != null)
                {
                    Console.WriteLine(i + ") " + names[i]);
                }



            }
        }

        public static void GetInput()
        {


            try
            {
                Console.WriteLine("Welcome to our C# class");
                PrintMenu();
                Console.WriteLine("Please enter index of student you want to learn about");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if(input > 7)
                {
                    throw new IndexOutOfRangeException("Please enter a valid index");

                }
                else
                {
                    Console.WriteLine("The student that you selected is {0}, what would you like to know about them?", names[input]);
                    LearnMore(input);

                }
                

            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Student not found, try another index");
                Console.WriteLine();
                GetInput();
            }

            



        }

        public static void LearnMore(int index)
        {
            Console.WriteLine("What would you like to learn more about? Hometown or Favorite Food");
            string input = Console.ReadLine().ToLower();

            if(input == "hometown")
            {
                Console.WriteLine("{0}'s hometown is {1}.", names[index], towns[index]);
            }
            if(input == "favorite food")
            {
                Console.WriteLine("{0}'s favorite food is {1}.", names[index], foods[index]);
            }

        }


    }
}
