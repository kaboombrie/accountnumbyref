/* Brie Prater
CIS 353
Professor Cain
06/20/2020
Assignment 3.2 */

using System;

namespace CIS353
{
	public class Assignment32
	{
		public static void Main(string[] args) // main method 
		{
			int[] accountNum = new int[5]; // creates array to hold accout numbers
			double[] balance = new double[5]; // creates array to hold account balances
			string[] lastName = new string[5]; // creates array to hold last names
			string userInput; // variable to hold input from menu
			fillAccounts(ref accountNum, ref balance, ref lastName); // calls fillAccounts method and passes arrays by reference
			Console.WriteLine("*****************************************");
			Console.WriteLine("Enter an a or A to search account numbers");
			Console.WriteLine("Enter a b or B to average the accounts");
			Console.WriteLine("Enter an x or X to exit program");
			Console.WriteLine("*****************************************");
			Console.WriteLine("Please Enter an option: ");
			userInput = Console.ReadLine(); // determines user input
			while (userInput != "x" || userInput != "X") // while loop menu
			{
				if (userInput == "a" || userInput == "A") // selects a
				{
					searchAccounts(ref accountNum, ref balance, ref lastName); // calls searchAccounts method and passes arrays by reference
					Console.WriteLine("*****************************************");
					Console.WriteLine("Enter an a or A to search account numbers");
					Console.WriteLine("Enter a b or B to average the accounts");
					Console.WriteLine("Enter an x or X to exit program");
					Console.WriteLine("*****************************************");
					Console.WriteLine("Please Enter an option: ");
					userInput = Console.ReadLine(); // determines users new input
				}
				else if (userInput == "b" || userInput == "B") // selects b
				{
					averageAccounts(ref balance); // calls averageAccounts method and passes balance array by reference
					Console.WriteLine("*****************************************");
					Console.WriteLine("Enter an a or A to search account numbers");
					Console.WriteLine("Enter a b or B to average the accounts");
					Console.WriteLine("Enter an x or X to exit program");
					Console.WriteLine("*****************************************");
					Console.WriteLine("Please Enter an option: ");
					userInput = Console.ReadLine(); // determines users new input
				}
				else if (userInput == "x" || userInput == "X") // selects x
				{
					Console.WriteLine("Good Bye!");
					return; // terminates program
				}
				else // if none of the menu option are selected
				{
					Console.WriteLine("The option you have entered is invalid.");
					Console.WriteLine("*****************************************");
					Console.WriteLine("Enter an a or A to search account numbers");
					Console.WriteLine("Enter a b or B to average the accounts");
					Console.WriteLine("Enter an x or X to exit program");
					Console.WriteLine("*****************************************");
					Console.WriteLine("Please Enter an option: ");
					userInput = Console.ReadLine(); // determines users new input
				}
			}
		}
		static void fillAccounts(ref int[] x, ref double[] y, ref string[] z) // fillAccounts method with int array, double array, string array parameters
		{
			for (int c = 0; c < 5; c++) // loops to fill all array indexes
			{
				Console.WriteLine("Please enter the integer account number: ");
				x[c] = Convert.ToInt32(Console.ReadLine()); // sets user input to accountNum array index c
				Console.WriteLine("Please enter the account balance: ");
				y[c] = Convert.ToDouble(Console.ReadLine()); // sets user input to balance array index c
				Console.WriteLine("Please enter the account holder's last name: ");
				z[c] = Console.ReadLine(); // sets user input to lastName array index c
			}
		}
		static void searchAccounts(ref int[] x, ref double[] y, ref string[] z) // searchAccounts method with int array, double array, string array parameters
		{
			int userSearch; // variable to hold user account selection
			int tally = 0; // variable to determine the account balance is not in array
			Console.WriteLine("Please enter an account number to search for: ");
			userSearch = Convert.ToInt32(Console.ReadLine());
			for (int c = 0; c < 5; c++) // loops through array indexes
			{
				if (x[c] == userSearch) // array index is equal to user input
				{
					Console.WriteLine("Account number {0} has a balance of ${1} for customer {2}.", x[c], y[c], z[c]); // returns account information
				}
				else if (x[c] != userSearch && tally == 4) // user input is not found and is the fifth iteration of the for loop
				{
					Console.WriteLine("You have entered an invalid account number.");
				}
				else
				{
					tally++; // increases tally count to avoid false invalid account message
				}
			}
		}
		static void averageAccounts(ref double[] y) // averageAccounts method with doubly array parameter
		{
			double totalBal; // variable to hold average of account balances
			totalBal = ((y[0] + y[1] + y[2] + y[3] + y[4]) / y.Length); // adds all indexes in balance array and divides by balance array length
			Console.WriteLine("The average dollar amount for all accounts is ${0}.", totalBal); // displays balance average
		}
	}
}