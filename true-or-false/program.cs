using System;

namespace TrueOrFalse
{
  class Program
  {
        static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {
        "The Great Wall of China is visible from space.", 
        "Water boils at 100 degrees Celsius at sea level.", 
        "The Earth is the only planet in our solar system that rotates clockwise.", 
        "The currency of Japan is the Yuan.", 
        "The Sahara Desert is the largest desert in the world.", 
        "Marie Curie was the first woman to win a Nobel Prize."
        };

      bool[] answers = {
        false,
        true,
        false,
        false,
        true,
        true
      };

      bool[] responses = new bool[questions.Length]

      int askingIndex = 0;
      bool isBool = false;


      foreach (string question in questions)
      {
        while(isBool = false)
        {
          Console.WriteLine("Question:");
          Console.WriteLine($"{question}");
          Console.Write("Answer 'True' or 'False': ");
          string input = Console.ReadLine();
          isBool = bool.TryParse(input, out isBool);
          if (isBool == true) {
            bool inputBool = bool.Parse(input);
          }
          else {
            Console.WriteLine($"{input} is an invalid answer.");
          }
          responses[askingIndex] = inputBool;
          Console.WriteLine(responses[askingIndex]);
          askingIndex += 1;
          
        }
      }
    }
  }
}