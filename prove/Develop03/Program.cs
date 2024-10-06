using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Reference refDoPrograma = new Reference("2 Nephi" , 22 , 2 );
        string text = "Behold, God is my salvation; I will trust, and not be afraid; for the Lord Jehovah is my strength and my song; he also has become my salvation. ";

        Scripture scripture1 = new Scripture(refDoPrograma , text);

        string prompt = "Press enter to continue or type 'quit' to finish:";
        string choice = "";
        while (choice != "quit") {
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine(prompt);
            choice = Console.ReadLine();
            if (scripture1.IsCompletelyHidden()) {
                break;
            }
            scripture1.HideRandomWords(2);
        }
    
    }
}