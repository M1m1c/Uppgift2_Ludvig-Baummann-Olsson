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
        public void BuyTicket()
        {
            MenyÖvning.Party TempParty = new MenyÖvning.Party();

            TempParty.AddPersonToParty(new MenyÖvning.Person(MenyÖvning.AgeClassification.adult, 120));
            TempParty.AddPersonToParty(new MenyÖvning.Person(MenyÖvning.AgeClassification.child, 80));
            TempParty.UpdateParty();

            Assert.AreEqual(200, TempParty.totalPrice);
            
            //Test
        }
    }
}
