using System;
using System.Collections.Generic;
using System.Text;

namespace MenyÖvning
{
    class TextRepeater
    {
        public static void RepeatText()
        {
            Console.WriteLine("Please enter something");
            string tempString = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(tempString);
            }
        }

    }
}
