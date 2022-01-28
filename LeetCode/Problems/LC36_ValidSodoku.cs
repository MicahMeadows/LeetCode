namespace LeetCode.Problems
{
    public static class LC36_ValidSodoku
    {
        public static bool IsValidSodoku(char[][] board)
        {
            // check all rows for duplicate n*n
            var validRows = allRowsValid(board); // O(n*n)

            var validColumns = validateColumns(board); // O(n*n)

            var validBoxes = validateBoxes(board); // O(n*n)


            // Time complexity: O(n^2)
            // Space complexity: O(n)
            return validRows && validColumns && validBoxes;
        }

        private static bool allRowsValid(char[][] board)
        {
            for (int row = 0; row < board.Length; row++)
            {
                HashSet<char> numberSet = new HashSet<char>();
                for (int col = 0; col < board.Length; col++)
                {
                    char curNum = board[row][col];
                    if (curNum == '.')
                        continue;
                    if (numberSet.Contains(curNum))
                        return false;
                    numberSet.Add(curNum);
                }
            }

            return true;
        }

        private static bool validateColumns(char[][] board)
        {
            // check all columns for duplicate n*n
            for (int col = 0; col < board.Length; col++)
            {
                HashSet<char> numberSet = new HashSet<char>();
                for (int row = 0; row < board.Length; row++)
                {
                    char curNum = board[row][col];
                    if (curNum == '.')
                        continue;
                    if (numberSet.Contains(curNum))
                        return false;
                    numberSet.Add(curNum);
                }
            }

            return true;
        }

        private static bool validateBoxes(char[][] board)
        {
            // check all boxes for duplicate n*n
            for (int boxRow = 0; boxRow < board.Length / 3; boxRow++)
            {
                for (int boxCol = 0; boxCol < board.Length / 3; boxCol++)
                {
                    HashSet<char> numberSet = new HashSet<char>();
                    for (int cellRow = 0; cellRow < board.Length / 3; cellRow++)
                    {
                        for (int cellCol = 0; cellCol < board.Length / 3; cellCol++)
                        {
                            int rowOffset = boxRow * board.Length / 3;
                            int colOffset = boxCol * board.Length / 3;
                            char curNum = board[rowOffset + cellRow][colOffset + cellCol];
                            if (curNum == '.')
                                continue;
                            if (numberSet.Contains(curNum))
                                return false;
                            numberSet.Add(curNum);
                        }
                    }
                }
            }
            return true;
        }
    }
}
