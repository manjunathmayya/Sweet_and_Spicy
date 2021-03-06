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
        [TestCase( "ab", 1, "a\nb\n" )]
        [TestCase( "abc", 1, "a\nb\nc\n" )]
        [TestCase( "abcd", 1, "a\nb\nc\nd\n" )]
        [TestCase( "abcd", 2, "ab\ncd\n" )]
        public void Test( string input, int width, string output )
        {
            Assert.AreEqual( output, Wrap( input, width ) );
        }

        private string Wrap( string input, int width )
        {
            string returnVal = "";
            char[] chars = input.ToCharArray();
            for( var i = 0; i < chars.Length; i++ )
            {
                char ch = chars[ i ];
                if( i % width == 0 )
                {
                    returnVal = returnVal + ch + "\n";
                }
                else
                {
                    returnVal = returnVal + ch;
                }
            }

            return returnVal;
        }
    }
}