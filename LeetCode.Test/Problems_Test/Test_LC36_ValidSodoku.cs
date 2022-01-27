using LeetCode.Problems;
using NUnit.Framework;

namespace LeetCode.Test.Problems_Test
{
    [TestFixture]
    public class Test_LC36_ValidSodoku
    {
        [Test]
        public void Example1_IsTrue()
        {
            var board = new char[,]
                {{'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                {'.', '.', '.', '.', '8', '.', '.', '7', '9'}};

            var result = LC36_ValidSodoku.IsValidSodoku(board);

            Assert.IsTrue(result);
        }
    }
}
