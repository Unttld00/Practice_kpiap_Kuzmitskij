namespace task3
{
    using System;

    class TwoDimensionalArray
    {
        private int[,] array;
        private int rows;
        private int columns;

        public TwoDimensionalArray(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            array = new int[rows, columns];
        }

        public int this[int i, int j]
        {
            get { return array[i, j]; }
            set { array[i, j] = value; }
        }

        public static TwoDimensionalArray operator --(TwoDimensionalArray arr)
        {
            if (arr.columns > 0)
            {
                int[,] newArray = new int[arr.rows, arr.columns - 1];
                for (int i = 0; i < arr.rows; i++)
                {
                    for (int j = 0; j < arr.columns - 1; j++)
                    {
                        newArray[i, j] = arr.array[i, j + 1];
                    }
                }
                arr.array = newArray;
                arr.columns--;
            }
            else
            {
                Console.WriteLine("Уменьшение колонок невозможно.");
            }
            return arr;
        }

        public void PrintArray()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            TwoDimensionalArray arr = new TwoDimensionalArray(3, 4);

            
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                }
            }

            Console.WriteLine("Исходный массив:");
            arr.PrintArray();

            
            arr--;
            arr--;

            Console.WriteLine("\nМассив после уменьшения количества столбцов на 2:");
            arr.PrintArray();
        }
    }
}