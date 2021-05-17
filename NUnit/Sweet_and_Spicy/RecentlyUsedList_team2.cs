/* -------------------------------------------------------------------------------------------------
   Restricted. Copyright (C) Siemens Healthcare GmbH, 2021. All rights reserved.
   ------------------------------------------------------------------------------------------------- */

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

namespace Sweet_and_Spicy
{
    [TestFixture]
    public class RecentlyUsedList_team2
    {
        private List<string> myList;

        [SetUp]
        public void Setup()
        {
            myList = new List<string>();
        }

        [TestCase( "a", "a" )]
        public void LastItemReturnedIsExpected( string input, string output )
        {
            var expected = new List<string> {input};
            var retList = GetList( input );
            int lastIndex = retList.Count - 1;
            Assert.AreEqual( expected[ 0 ], retList[ lastIndex ] );
        }

        [TestCase( "1", "1" )]
        public void ListReturnsExpectedItems( string input, string outp )
        {
            var expected = new List<string>();
            expected.Add( outp );
            Assert.AreEqual( expected, GetList( input ) );
        }

        [Test]
        public void ListReturnsEmptyList()
        {
            Assert.AreEqual( 0, GetList( "" ).Count );
        }

        private List<string> GetList( string input )
        {
            if( input != string.Empty )
            {
                myList.Add( input );
            }

            return myList;
        }
    }
}