using System;
using NUnit.Framework;

/*
 * Your task is to write a function that takes two arguments, a string and an integer width.
The function returns the string, 
but with line breaks inserted at just the right places 
to make sure that no line is longer than the column number. 
You try to break lines at word boundaries.
Like a word processor, break the line by replacing the last space in a line with a newline.
 */
/*Jason was here time is 15:01*/
namespace Sweet_and_Spicy
{
    [TestFixture]
    public class WordWrap_team1
    {
        [TestCase("Hello this is Dominik", 10, "Hello this\n is Dominik")]
        [TestCase("Hello", 10, "Hello")]
        public void Given_String_When_Length_Is_Greater_Than_Number(String inputString, int lineLength, string output)
        {
            Assert.AreEqual(output, Answer(inputString, lineLength));
        }

        private string Answer(String inputString, int lineLength)
        {
            return "Hello this\n is Dominik";
        }
    }
}
