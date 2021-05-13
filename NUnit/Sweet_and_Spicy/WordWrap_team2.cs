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
        [Test]
        public void Given_When_Then()
        {
            Assert.AreEqual("42",Answer());
        }

        private string Answer()
        {
            return "?";
        }
    }
}
