namespace zad1
{
    /// <summary>
    /// Класс для представления двумерного массива целых чисел с функциями доступа к элементам и уменьшения количества столбцов.
    /// </summary>
    public class TwoDimensionalArray
    {
        /// <summary>
        /// Внутренний массив целых чисел для хранения данных.
        /// </summary>
        private int[,] array;

        /// <summary>
        /// Количество строк в массиве.
        /// </summary>
        private int rows;

        /// <summary>
        /// Количество столбцов в массиве.
        /// </summary>
        private int columns;

        /// <summary>
        /// Инициализирует новый экземпляр TwoDimensionalArray с указанным количеством строк и столбцов.
        /// </summary>
        /// <param name="rows">Количество строк в массиве.</param>
        /// <param name="columns">Количество столбцов в массиве.</param>
        public TwoDimensionalArray(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            array = new int[rows, columns];
        }

        /// <summary>
        /// Свойство-индексатор для доступа к элементам массива и их установки.
        /// </summary>
        /// <param name="i">Индекс строки.</param>
        /// <param name="j">Индекс столбца.</param>
        /// <returns>Значение в указанном индексе.</returns>
        public int this[int i, int j]
        {
            get { return array[i, j]; }
            set { array[i, j] = value; }
        }

        /// <summary>
        /// Перегруженный оператор декремента (-) для уменьшения количества столбцов в массиве.
        /// </summary>
        /// <param name="arr">Экземпляр TwoDimensionalArray, который нужно изменить.</param>
        /// <returns>Измененный экземпляр TwoDimensionalArray с уменьшенным количеством столбцов.</returns>
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
                Console.WriteLine("Уменьшение количества столбцов невозможно (Column reduction is not possible).");
            }
            return arr;
        }

        /// <summary>
        /// Печатает содержимое TwoDimensionalArray в консоль.
        /// </summary>
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

            Console.WriteLine("Исходный массив (Original array):");
            arr.PrintArray();

            arr--;
            arr--;

            Console.WriteLine("\nМассив после уменьшения количества столбцов на 2 (Array after reducing columns by 2):");
            arr.PrintArray();
        }
    }
}