using projektParadygmaty;
using System;
using System.IO;
using System.Text.Json;

static void Main(string[] args)
{
    Excersise excersise1 = new Excersise();
    Excersise excersise2 = new Excersise();
    Training training = new Training();

    excersise1.name = "name1";
    excersise1.description = "description1";
    excersise1.numberOfRepetes = 1;
    excersise1.secondsOfBrake = 10;

    excersise2.name = "name2";
    excersise2.description = "description2";
    excersise2.numberOfRepetes = 2;
    excersise2.secondsOfBrake = 20;

    training.Excersisees = [excersise1, excersise2];

    
    




bool work = true;
    while (work)
    {
        Console.Clear();
        Console.WriteLine("==== MENU ====");
        Console.WriteLine("1. Wyswietl trening calosciowy");
        Console.WriteLine("2. Wyswietl trening pierwszy");
        Console.WriteLine("3. Wyswietl trening drugi");
        Console.WriteLine("0. Wyjście");


        //string choice = Console.ReadLine();
        string choice = "2";

        switch (choice)
        {
            case "1":

                Methods.ReadRegime(training);
                break;
            case "2":
                Methods.ReadTraining(training, 0);
                break;
            case "3":
                Methods.ReadTraining(training, 1);
                break;
            case "0":
                Console.WriteLine("Closed");
                work = false;
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                break;
        }

        if (work)
        {
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();
        }
    }
}


