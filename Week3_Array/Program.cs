﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Provide a sentence and I will capitalize all of the words:");
string input = Console.ReadLine();
string cleanedInput = input.Trim();
if(string.IsNullOrEmpty(cleanedInput))
{
  Console.WriteLine("Invalid input: Try again");
  Environment.Exit(0);
}

string[] words = cleanedInput.Split(' ');
Console.Clear();
Console.WriteLine("Here is your capitalized version:");
Console.Write(">> ");

foreach (string word in words)
{
    Console.Write(char.ToUpper(word[0]) + word.Substring(1) + ' ' );
}
