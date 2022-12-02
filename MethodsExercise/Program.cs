using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Reflection;
using System;

namespace MethodsExercise
{
    public class Program

    {
        static void Main(string[] args)
        {
            //****Methods Exercise 1
            //Write a C# program that takes user input and creates a story:
            //Inside the scope of your Main() method

            //Bonus (Request Help!!)
            //*Bonus* => Abstract away the code into methods and call them in your Main()

            //Console.WriteLine("Hello, World!");

            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("How old are you?");
            //string age = Console.ReadLine();

            //Console.WriteLine("What is your dog's name?");
            //string userDogName = Console.ReadLine();

            //Console.WriteLine("What's the breed of your dog?");
            //string userDogBreed = Console.ReadLine();

            //Console.WriteLine("Does he bite?");
            //string userDogBite = Console.ReadLine();

            //Console.WriteLine($"There was a kid named {userName}, she was {age} years old.");
            //Console.WriteLine($"Her dog is named {userDogName}.");
            //Console.WriteLine($"The dog's breed is {userDogBreed} meaning soon to be anything.");
            //Console.WriteLine($"Everyone wants to know if the dog bites? {userDogBite}");
            //Console.WriteLine($"{userName} loves {userDogName} but wished he wouldn't bite everyone.");


            //-------------------------EXERCISE 2------------------------------------------

            //***Methods Exercise 2
            //Declare 5 methods:
            //1.Declare 5 methods: 1 Add method, 1 Subtract method, Multiply method, Divide method and 1 Modulus method
            // 2.Call each of the methods in your Main() method
            // 3.* Bonus * => Change the functions to use the params keyword to support a range of arguments. 1 Add() method that takes as many arguments as needed
            // Sum(2, 4) would return 6
            // Sum(2, 4, 6) would return 12
            // Sum(1, 1, 1, 1, 1) would return 5

            Sum();
            Mult();
        }

        public static void Sum()
        {

            //int sum = num1 + num2;-------DONE

            //Console.WriteLine("Pick a number add: ");
            //var num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pick a second number add: ");
            //var num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the sum? ");
            //Console.WriteLine(num1 + num2);
        }
        public static void Mult()
        {
            //int mult = mult1 * mult2;-----DONE

            //Console.WriteLine("Pick a number to multiple: ");
            //int mult1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pick a second number to multiple: ");
            //int mult2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the product? ");
            //Console.WriteLine(mult1 * mult2);

        }

    }   

}



               

        
                
    
                        

    


    






