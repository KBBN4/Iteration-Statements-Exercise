using System;
using System.ComponentModel;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 ** done **
        static void PrintNumbers1000()
        {

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time ** done **

        static void Skip()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }



        //Write a method to accept two integers as parameterss and check whether they are equal or not ** review **

        static void Equal(int a, int b)
        {
            if (a == b)
                Console.WriteLine(" your lucky");

            else { Console.WriteLine(" nope, not the same"); }
        }



        //Write a method to check whether a given number is even or odd 

        static void EvenOdd()
        {
            Console.WriteLine(" choose a number from 1-10 ");

            var num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(" your number is even");
            }
            else
            {
                Console.WriteLine(" your number is odd");
            }





            //Write a method to check whether a given number is positive or negative ** done**
            static void check()
            {
                Console.WriteLine(" pick a number");
                int positive = int.Parse(Console.ReadLine());

                if (positive >= 0)

                {
                    Console.WriteLine(" you have an even number");

                }
                else { Console.WriteLine(" you have a negative number"); }
            }


            //Write a method to read the age of a candidate and determine whether they can vote.    ** done **

            static void vote()
            {
                int votingAge = 18;
                Console.WriteLine(" please,cd .." +
                    " enter age");
                int age = int.Parse(Console.ReadLine());

                if (age >= votingAge)
                { Console.WriteLine(" great,you can vote"); }
                else
                { Console.Write(" try again at age 18 "); }
            }


            //Hint: Use Parse or the safer TryParse() for an extra challenge
            //Parse()
            //TryParse()

            //Heatin Up Section:
            //Write a method to check if an integer(from the user) is in the range -10 to 10 **done**

            static void Number()
            {

                Console.WriteLine(" choose a number between -10 and 10 ");
                int answer = int.Parse(Console.ReadLine());

                if (answer >= 0)
                { Console.WriteLine(" you have a positive integer"); }
                if (answer <= 0)
                { Console.WriteLine(" you have a negative integer"); }
            }

            //Write a method to display the multiplication table(from 1 to 12) of a given integer
            static void Multiplication(int digit)
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine(i * digit);
                }
            }




            //Call the methods to test them in the Main method below
            static void Main(string[] args)
            {

                PrintNumbers1000();        //Write a method that will print to the console all numbers 1000 through - 1000 ** done **

                Skip();                    //Write a method that will print to the console numbers 3 through 999 by 3 each time ** done **

                EvenOdd();                 //Write a method to check whether a given number is even or odd 

                Equal(2, 5);               //Write a method to accept two integers as parameterss and check whether they are equal or not 

                check();                   //Write a method to check whether a given number is positive or negative

                vote();                    //Write a method to read the age of a candidate and determine whether they can vote.

                Number();                  //Write a method to check if an integer(from the user) is in the range -10 to 10

                Multiplication(5);         //Write a method to display the multiplication table(from 1 to 12) of a given integer
























            }

        }
    }
}
