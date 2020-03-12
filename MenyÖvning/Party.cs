using System;
using System.Collections.Generic;
using System.Text;

namespace MenyÖvning
{
    class Party
    {
        private List<Person> people = new List<Person>();
        public int children { get; set; }
        public int adults { get; set; }
        public int seniorCitizens { get; set; }
        public int totalPrice { get; set; }

        public void AddPersonToParty(Person PartyMember)
        {
            people.Add(PartyMember);
        }

        public Person[] GetPeople()
        {
            return people.ToArray();
        }

        public void UpdateParty()
        {
            children = 0;
            adults = 0;
            seniorCitizens = 0;
            totalPrice = 0;
            foreach (var person in people)
            {
                switch (person.Classification)
                {
                    case AgeClassification.child:
                        children++;
                        break;
                    case AgeClassification.senior:
                        seniorCitizens++;
                        break;
                    case AgeClassification.adult:
                        adults++;
                        break;
                }
                totalPrice += person.Price;
            }
        }
    }
}
