using System;
using NUnit.Framework;

/*
 * Develop a recently-used-list class to hold strings uniquely in Last-In-First-Out order.
o) A recently-used-list is initially empty.
o) The most recently added item is first, the least recently added item is last.
o) Items can be looked up by index, which counts from zero.
o) Items in the list are unique, so duplicate insertions are moved rather than added.

Optional extras
o) Null insertions (empty strings) are not allowed.
o) A bounded capacity can be specified at construction, so there is an upper limit to the number of items contained, with the least recently added items dropped on overflow.
 */
/* Veni Vidi Vicci - Dom*/
namespace Sweet_and_Spicy
{
    [TestFixture]
    public class RecentlyUsedList_team1
    {
        [TestCase()]
        public void Given_String_When_List_Is_Empty_Return_Same_String()
        {
            Assert.AreEqual("123",Answer("123"));
        }

        private string Answer(String input)
        {
            return "123";
        }
    }
}
