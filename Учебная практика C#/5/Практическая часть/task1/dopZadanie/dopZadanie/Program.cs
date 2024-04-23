namespace dopZadanie
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = 7;
            int[,] array = new int[n, n];

            int num = 1;
            int row = 0;
            int col = 0;

            int maxRow = n - 1;
            int maxCol = n - 1;

            while (num <= n * n)
            {
                for (int i = col; i <= maxCol; i++)
                {
                    array[row, i] = num++;
                }

                for (int i = row + 1; i <= maxRow; i++)
                {
                    array[i, maxCol] = num++;
                }

                for (int i = maxCol - 1; i >= col; i--)
                {
                    array[maxRow, i] = num++;
                }

                for (int i = maxRow - 1; i > row; i--)
                {
                    array[i, col] = num++;
                }

                row++;
                col++;
                maxRow--;
                maxCol--;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}