using System;
using System.Collections.Generic;
using System.Text;

namespace MenyÖvning
{
    class Person
    {
       public Person(AgeClassification inClassification, int inPrice)
        {
            Classification = inClassification;
            Price = inPrice;
        }
       
       
        public AgeClassification Classification { get; set; }
        public int Price { get; set; }
        
        
    }
}
