using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
    
        int anwser = 0;

        do{
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity ");
            Console.WriteLine(" 2. Start reflecting activity ");
            Console.WriteLine(" 3. Start listing activity ");
            Console.WriteLine(" 4. Quit ");
            Console.Write("Select a choice from the menu: ");
            anwser = int.Parse(Console.ReadLine());


            if (anwser == 1) 
            {        
                Console.Clear();
                string text ="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                
                BreathingActivity activity1 = new BreathingActivity("Breathing", text);
                activity1.DisplayStartingMessage();

                int duration = int.Parse(Console.ReadLine());
                activity1.SetDuration(duration);
                Console.Clear();
                Console.WriteLine("Get ready...");
                activity1.ShowSpinner(5);
                Console.WriteLine(" ");
                
                activity1.Run();
                activity1.DisplayEndingMessage();
          
                
            }

            else if (anwser == 2) 
        
            {
                Console.Clear();
                string text = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                RefletingActivity activity1 = new RefletingActivity("Reflecting",text);
                
                activity1.DisplayStartingMessage();
                int duration = int.Parse(Console.ReadLine());
                activity1.SetDuration(duration);
                Console.Clear();
                Console.WriteLine("Get ready...");
                activity1.ShowSpinner(5);
                Console.WriteLine(" ");

                activity1.Run();
                activity1.DisplayEndingMessage();
            }
                
                
                
        
            else if (anwser == 3 )
            {
                Console.Clear();
                string text = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity activity1 = new ListingActivity("Listing", text);
                activity1.DisplayStartingMessage();
                int duration = int.Parse(Console.ReadLine());
                activity1.SetDuration(duration);
                Console.Clear();
                Console.WriteLine("Get ready...");
                activity1.ShowSpinner(5);
                Console.WriteLine(" ");

                activity1.Run();
                activity1.DisplayEndingMessage();
            }

        }while (anwser != 4);
    }
}



//
/* 
public class Activity
{
    public string Name { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        // Criando uma nova instância da classe Activity
        Activity activity = new Activity();

        // Definindo o valor da propriedade Name
        activity.Name = "Corrida";

        // Obtendo o valor da propriedade Name
        Console.WriteLine(activity.Name); // Saída: Corrida
    }
}*/
