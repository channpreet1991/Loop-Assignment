//while

bool nameValidation = false;
while (nameValidation == false) {
Console.Write("Enter your name: ");  // Asks for your name
userName = Console.ReadLine();

if (Regex.IsMatch(userName, @"^[a-zA-Z- ]+$"))  // Validates the input containts characters and/or spaces
{
   nameValidation = true;              
}
else  // Error message if the input is not valid
{
   Console.Clear();  // Clear screen
   Console.WriteLine("Please enter a valid name.");
   nameValidation = false;
 }
}

//do

using System;

namespace Loops {
  class Program {
     static void Main(string[] args) {
        /* local variable definition */
        int a = 10;
        
        /* do loop execution */
        do {
           Console.WriteLine("value of a: {0}", a);
           a = a + 1;
        } 
        while (a < 20);
        Console.ReadLine();
     }
  }
} 

