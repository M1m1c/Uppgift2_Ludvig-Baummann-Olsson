using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
    [TestClass]
    public class TicketTests
    {
        [TestMethod]
        public void CreatePersonTest()
        {
            MenyÖvning.Person a = MenyÖvning.Program.CreatePerson(40);
            MenyÖvning.Person b = MenyÖvning.Program.CreatePerson(10);
            MenyÖvning.Person c = MenyÖvning.Program.CreatePerson(70);

            Assert.AreEqual(120, a.Price);
            Assert.AreEqual(MenyÖvning.AgeClassification.adult, a.Classification);
            Assert.AreEqual(80, b.Price);
            Assert.AreEqual(MenyÖvning.AgeClassification.child, b.Classification);
            Assert.AreEqual(90, c.Price);
            Assert.AreEqual(MenyÖvning.AgeClassification.senior, c.Classification);
        }

        [TestMethod]
        public void TotalPriceTest()
        {
            MenyÖvning.Party TempParty = new MenyÖvning.Party();

            TempParty.AddPersonToParty(new MenyÖvning.Person(MenyÖvning.AgeClassification.adult, 120));
            TempParty.AddPersonToParty(new MenyÖvning.Person(MenyÖvning.AgeClassification.child, 80));
            TempParty.UpdateParty();
            Assert.AreEqual(200, TempParty.totalPrice);           
        }

        [TestMethod]
        public void DeterminePriceTest()
        {
            MenyÖvning.AgeClassification a;
            int b;
            MenyÖvning.Program.DeterminePrice(20, out a, out b);
            Assert.AreEqual(120, b);
            Assert.AreEqual(MenyÖvning.AgeClassification.adult, a);          
        }


    }
}
