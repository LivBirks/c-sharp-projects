using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.Write("Chose either 'Encrypt' or 'Decrypt' to begin: "); 
      string choice = Console.ReadLine().ToLower();

      Console.Write("Enter a message to cipher: ");
      string message = Console.ReadLine();

      if (choice.ToLower() == "encrypt") {
        Encrypt(alphabet, message);
      }
      if (choice.ToLower() == "decrypt") {
        Decrypt(alphabet, message);
      }
      
    }

    static void Encrypt(char[] alphabet, string message) 
    {
      char[] secretMessage = message.ToCharArray();
      
      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++) {
        char letter = secretMessage[i];

        if (Char.IsLetter(letter) == false){
          continue;
        }

        int letterIndex = Array.IndexOf(alphabet, letter);
        
        int newLetterIndex = (letterIndex += 3) % 26;

        char newLetter = alphabet[newLetterIndex];

        encryptedMessage[i] = newLetter;
      }
      
      Console.WriteLine($"Ciphered message is:\n{String.Join("", encryptedMessage)}");
    }

    static void Decrypt(char[] alphabet, string message) 
    {
      char[] secretMessage = message.ToCharArray();
      
      char[] decryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++) {
        char letter = secretMessage[i];

        if (Char.IsLetter(letter) == false){
          continue;
        }

        int letterIndex = Array.IndexOf(alphabet, letter);
        
        int newLetterIndex = (letterIndex -= 3);

        if (newLetterIndex < 0) {
          newLetterIndex *= -1;
        }

        char newLetter = alphabet[newLetterIndex];

        decryptedMessage[i] = newLetter;
      }
      
      Console.WriteLine($"Deciphered message is:\n{String.Join("", decryptedMessage)}");
    }
  }
}