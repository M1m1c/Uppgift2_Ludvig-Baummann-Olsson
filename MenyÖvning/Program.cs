using System;
using System.Collections.Generic;

namespace MenyÖvning
{
   public class Program
    {
        static bool RunProgram = true;
        static int ResultTotalPrice=0;
        public static void Main(string[] args)
        {
            while (RunProgram)
            {
                
                Console.WriteLine("\nHello!\n" +
                    "To make a seleciton enter one of the following numbers:\n" +
                    "0 to exit aplication\n" +
                    "1 to buy tickets\n" +
                    "2 to write something that will repeat\n" +
                    "3 to write a sentence with a minimum of three words");
                int g = 0;

                switch (GetIntFromString(GetInputString()))
                {
                    case 0:
                        RunProgram = false;
                        break;
                    case 1:
                        BuyTickets();
                        break;
                    case 2:
                        MenyÖvning.TextRepeater.RepeatText();
                        //RepeatText();
                        break;
                    case 3:
                        MenyÖvning.ThreeWord.WriteThreeWords();
                        //WriteThreeWords();
                        break;
                    default:
                        Console.WriteLine("\nsorry, that was not a valid selection. Please try again.\n");
                        break;
                }
            }
        }

        private static void BuyTickets()
        {
            Party PeopleAttending = new Party();
           
            int amountOfPeople = DetermineAmountOfPeople();
            for (int i = 0; i < amountOfPeople; i++)
            {
                PeopleAttending.AddPersonToParty(CreatePerson(GetAgeInput()));
                
            }
            PeopleAttending.UpdateParty();
            ResultTotalPrice = PrintPeople(PeopleAttending);
        }

        private static int DetermineAmountOfPeople()
        {
            int amountOfPeople = 0;

            while (amountOfPeople <= 0) 
            {
                Console.WriteLine("Please enter the amount of people attending");
                amountOfPeople = GetIntFromString(GetInputString());
            }
            return amountOfPeople;
        }

        private static int PrintPeople(Party partyToPrint)
        {
           
            Console.WriteLine($"\nChild tickets: { partyToPrint.children}" +
                $"\nSenior tickets: { partyToPrint.seniorCitizens}" +
                $"\nAdult tickets: { partyToPrint.adults}" +
                $"\nTotal Attendants: { partyToPrint.children + partyToPrint.seniorCitizens + partyToPrint.adults}" +
                $"\n-----------------------" +
                $"\nTotal Price: {partyToPrint.totalPrice}kr\n");

            return partyToPrint.totalPrice;
        }

        private static Person CreatePerson(int age)
        {
            AgeClassification tempClassification;
            int tempInt;
            DeterminePrice(age, out tempClassification, out tempInt);
            Person TempPerson = new Person(tempClassification, tempInt);
            return TempPerson;           
        }
        
        private static string GetInputString()
        {
            return Console.ReadLine();
        }
        private static int GetIntFromString(string input)
        {
            int inputInt = 0;
            if (!int.TryParse(input, out inputInt))
            {
                inputInt = -1;
            }
            return inputInt;
        }

        private static int GetAgeInput()
        {
            int age = 0;

            while (age <= 0)
            {
                Console.WriteLine("Please enter your age to get your price class");
                age = GetIntFromString(GetInputString());
            }

            return age;
            
        }

        private static void DeterminePrice(int age, out AgeClassification classification, out int price)
        {
            if (age < 5)
            {
                classification = AgeClassification.child;
                price = 0;
            }
            else if (age < 20)
            {
                classification = AgeClassification.child;
                price = 80;
            }
            else if (age > 64)
            {
                classification = AgeClassification.senior;
                price = 90;
            }
            else if (age > 100)
            {
                classification = AgeClassification.senior;
                price = 0;
            }
            else
            {
                classification = AgeClassification.adult;
                price = 120;
            }                    
        }       
    }
}
