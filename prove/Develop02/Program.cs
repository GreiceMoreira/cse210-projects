using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Program 
{
    static void Main(string[] args)
    {   

        PromptGenerator promptGenerator = new PromptGenerator();
        Journal myJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        int anwser = 0;

        do {
            Console.WriteLine("Please select one of the following choices. " );
            Console.WriteLine("1 - Write " );
            Console.WriteLine("2 - Display Journal " );
            Console.WriteLine("3 - Load (the file)" );
            Console.WriteLine("4 - Save (in a file) " );
            Console.WriteLine("5 - Quit" );
            Console.WriteLine("What would you like to do? " );
            string userChoice = Console.ReadLine();
            anwser = int.Parse(userChoice);
    
        if (anwser == 1) 
        {        
                 /* Create a new object(day) Class Entry
                 AddEntry() - class entry; Class Journal
                  */
            /*Date Time */
            DateTime theCurrentTime = DateTime.Now;
            Entry day = new Entry();
            day._dateText = theCurrentTime.ToShortDateString();

            
            day._promptText = promptGenerator.GetRandomPrompt();
            Console.WriteLine("What would you like to say? " );
            day._entryText = Console.ReadLine();

            myJournal.AddEntry(day);

        }

        else if (anwser == 2) 
        
        {
            myJournal.DisplayAll();
        }
        
        else if (anwser == 3 )
        {
            Console.WriteLine("What is the filename? ");
            string fileName = Console.ReadLine() ; 
            Journal journalFromFile = new Journal();
            journalFromFile.LoadFromFile(fileName);
            Console.WriteLine("Loaded content:");
            journalFromFile.DisplayAll();
        }

        else if (anwser == 4 )
        {
            Console.WriteLine("What will be the filename? ");
            string userFile = Console.ReadLine() ; 
            myJournal.SaveToFile(userFile);
        }


        }while (anwser != 5);


    }


}