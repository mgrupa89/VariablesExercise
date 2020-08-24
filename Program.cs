using System;

namespace variables
{
	class Program
	{
		static void Main(string[] args)
		{
			string dogName = "Reinhardt";
			int dogAge = 3;
			char firstLetter = 'R'; //single characters NEED single quotes
			bool likeDogs;
			double toys = 32;
			decimal timeOwned = 2.5m;




			Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old. \n" + $"The first letter of his name begins with {firstLetter} and the number of toys he has is {toys}. \n" + $"I have owned him for {timeOwned}. \n" + "Do you like dogs?");
			Console.Write("> ");


			string userInput = (Console.ReadLine().ToLower().Trim());
			

			

			if (userInput == "no")
			{
				likeDogs = false;
				Console.WriteLine("You Monster!");

			}



			else if (userInput == "yes")

			{
				likeDogs = true;
				Console.WriteLine("Awesome, I like dogs too!");


			}
			else
			{
				Console.WriteLine("Please enter a yes or no answer.");
			}
		}
	}
}
