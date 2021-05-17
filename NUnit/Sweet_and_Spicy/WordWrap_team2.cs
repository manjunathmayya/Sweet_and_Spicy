/* -------------------------------------------------------------------------------------------------
   Restricted. Copyright (C) Siemens Healthcare GmbH, 2021. All rights reserved.
   ------------------------------------------------------------------------------------------------- */

using NUnit.Framework;

/*
 * Your task is to write a function that takes two arguments, a string and an integer width.
The function returns the string, 
but with line breaks inserted at just the right places 
to make sure that no line is longer than the column number. 
You try to break lines at word boundaries.
Like a word processor, break the line by replacing the last space in a line with a newline.
 */
namespace Sweet_and_Spicy
{
    [TestFixture]
    public class WordWrap_team2
    {
        [TestCase( "ab", 1, "a\nb" )]
        [TestCase( "abc", 1, "a\nb\nc" )]
        [TestCase( "abcd", 1, "a\nb\nc\nd" )]
        public void Test( string input, int width, string output )
        {
            Assert.AreEqual( output, Wrap( input, width ) );
        }

        private string Wrap( string input, int width )
        {
            char[] chars = input.ToCharArray();
            string ret = string.Join( "\n", chars );

            return ret;
        }
    }
}