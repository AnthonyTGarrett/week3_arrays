// See https://aka.ms/new-console-template for more information
Console.WriteLine("Provide a sentence and I will capitalize all of the words:");
string input = Console.ReadLine();
string cleanedInput = input.Trim();

string[] words = cleanedInput.Split(' ');
Console.Clear();

foreach (string word in words)
{
    Console.Write(char.ToUpper(word[0]) + word.Substring(1) + ' ' );
}

