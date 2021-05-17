using System;
using System.Collections.Generic;
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
        [TestCase("123", "123")]
        public void Given_String_When_List_Is_Empty_Return_Same_String(string input, string output)
        {
            Assert.AreEqual(output, Answer(input));
        }

        [TestCase("abc", "abc")]
        public void Given_String_When_Provided_String_Is_First_Return_Same_String(string input, string output)
        {
            List<String> listString = new List<string>();
            Assert.AreEqual(output, GetFirstElement(listString, input));
        }

        [TestCase("abc", "abc")]
        public void Given_List_With2Items_Return_Last_ItemFromList(string input, string output)
        {
            List<String> listString = new List<string>();
            listString.Add("123");
            listString.Add("abc");
            Assert.AreEqual(output, GetLastElement(listString, input));
        }

        private string GetLastElement(List<string> listString, string input)
        {
            return listString[listString.Count - 1];
        }

        private string Answer(String input)
        {
            return input;
        }

        private string GetFirstElement(List<String> stack, string input)
        {
            return stack[0];
        }
    }
}
