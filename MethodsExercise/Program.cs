namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //Methods Exercise 1
            //Bonus (Request Help!!)

            Console.WriteLine("Hello, World!");
            
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your dog's name?");
            string userDogName = Console.ReadLine();

            Console.WriteLine("What's the breed of your dog?");
            string userDogBreed = Console.ReadLine(); 

            Console.WriteLine("Does he bite?");
            string userDogBite = Console.ReadLine();

            Console.WriteLine($"There was a kid named {userName}, she was {age} years old.");
            Console.WriteLine($"Her dog is named {userDogName}.");
            Console.WriteLine($"The dog's breed is {userDogBreed} meaning soon to be anything.");
            Console.WriteLine($"Everyone wants to know if the dog bites? {userDogBite}");
            Console.WriteLine($"{userName} loves {userDogName} but wished he wouldn't bite everyone.");




        }
    }
}
