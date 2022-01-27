namespace LeetCode.Problems
{
    public static class LC36_ValidSodoku
    {
        public static bool IsValidSodoku(char[,] board)
        {
            if (board.GetLength(0) % 3 != 0)
                return false;

            if (board.GetLength(1) % 3 != 0)
                return false;

            // check all rows for duplicate n*n
            for (int row = 0; row < board.GetLength(0); row++)
            {
                HashSet<int> numberSet = new HashSet<int>();
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    int curNum = board[row, col];
                    if (numberSet.Contains(curNum))
                        return false;
                    numberSet.Add(curNum);
                }
            }

            // check all columns for duplicate n*n
            for (int col = 0; col < board.GetLength(1); col++)
            {
                HashSet<int> numberSet = new HashSet<int>();
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    int curNum = board[row, col];
                    if (numberSet.Contains(curNum))
                        return false;
                    numberSet.Add(curNum);
                }
            }

            // check all boxes for duplicate n*n
            for (int boxRow = 0; boxRow < board.GetLength(0) / 3; boxRow++)
            {
                for (int boxCol = 0; boxCol < board.GetLength(1) / 3; boxCol++)
                {
                    HashSet<int> numberSet = new HashSet<int>();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            int curNum = board[i, j];
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
