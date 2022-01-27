namespace LeetCode.Problems
{
    public static class LC36_ValidSodoku
    {
        public static bool IsValidSodoku(char[][] board)
        {
            const int boardSize = 9;

            // check all rows for duplicate n*n
            for (int row = 0; row < boardSize; row++)
            {
                HashSet<char> numberSet = new HashSet<char>();
                for (int col = 0; col < boardSize; col++)
                {
                    char curNum = board[row][col];
                    if (curNum == '.')
                        continue;
                    if (numberSet.Contains(curNum))
                        return false;
                    numberSet.Add(curNum);
                }
            }

            // check all columns for duplicate n*n
            for (int col = 0; col < boardSize; col++)
            {
                HashSet<char> numberSet = new HashSet<char>();
                for (int row = 0; row < boardSize; row++)
                {
                    char curNum = board[row][col];
                    if (curNum == '.')
                        continue;
                    if (numberSet.Contains(curNum))
                        return false;
                    numberSet.Add(curNum);
                }
            }


            // check all boxes for duplicate n*n
            for (int boxRow = 0; boxRow < boardSize / 3; boxRow++)
            {
                for (int boxCol = 0; boxCol < boardSize / 3; boxCol++)
                {
                    HashSet<char> numberSet = new HashSet<char>();
                    for (int cellRow = 0; cellRow < boardSize / 3; cellRow++)
                    {
                        for (int cellCol = 0; cellCol < boardSize / 3; cellCol++)
                        {
                            int rowOffset = boxRow * 3;
                            int colOffset = boxCol * 3;
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

            // n*n + n*n + n*n = 3n*n
            // Time complexity: O(n^2)
            return true;
        }
    }
}
