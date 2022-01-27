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
            var board = new char[][]
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' },
            };

            var result = LC36_ValidSodoku.IsValidSodoku(board);

            Assert.IsTrue(result);
        }

        [Test]
        public void Example2_IsFalse()
        {
            var board = new char[][]
            {
                new char[] {'8', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[]{'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[]{'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[]{'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[]{'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new char[]{'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[]{'.', '.', '.', '.', '8', '.', '.', '7', '9'},
            };

            var result = LC36_ValidSodoku.IsValidSodoku(board);

            Assert.IsFalse(result);
        }

        [Test]
        public void Example3_IsFalse()
        {
            var board = new char[][]{
                new char[]{'.', '.', '.', '.', '5', '.', '.', '1', '.'},
                new char[]{'.', '4', '.', '3', '.', '.', '.', '.', '.'},
                new char[]{'.', '.', '.', '.', '.', '3', '.', '.', '1'},
                new char[]{'8', '.', '.', '.', '.', '.', '.', '2', '.'},
                new char[]{'.', '.', '2', '.', '7', '.', '.', '.', '.'},
                new char[]{'.', '1', '5', '.', '.', '.', '.', '.', '.'},
                new char[]{'.', '.', '.', '.', '.', '2', '.', '.', '.'},
                new char[]{'.', '2', '.', '9', '.', '.', '.', '.', '.'},
                new char[]{'.', '.', '4', '.', '.', '.', '.', '.', '.'}
            };

            var result = LC36_ValidSodoku.IsValidSodoku(board);

            Assert.IsFalse(result);
        }
    }
}
