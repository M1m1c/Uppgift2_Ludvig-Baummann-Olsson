using System;
using System.Collections.Generic;
using System.Text;

namespace MenyÖvning
{
    class ThreeWord
    {
        public static void WriteThreeWords()
        {
            while (true)
            {
                Console.WriteLine("\nPlease enter a sentence containing three words.");
                string input = Console.ReadLine();

                var values = input.Split(' ');
                List<string> tempStringList = new List<string>(values);

                foreach (var item in values)
                {
                    if (string.IsNullOrEmpty(item))
                    {
                        tempStringList.Remove(item);
                    }
                }
                values = tempStringList.ToArray();

                if (values.Length >= 3)
                {
                    Console.WriteLine(values[2]);
                    break;
                }
            }
        }
    }
}
