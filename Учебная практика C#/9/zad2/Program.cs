namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

           
            int rows1 = random.Next(2, 10);
            int cols1 = random.Next(2, 10);
            Matrix matrix1 = new Matrix(rows1, cols1);

            int rows2 = random.Next(2, 10);
            int cols2 = random.Next(2, 10);
            Matrix matrix2 = new Matrix(rows2, cols2);

            
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    matrix1[i, j] = random.NextDouble() * 10;
                    matrix2[i, j] = random.NextDouble() * 10;
                }
            }

            
            Console.WriteLine("Матрица matrix1:");
            matrix1.Print();
            Console.WriteLine("\nМатрица matrix2:");
            matrix2.Print();

            
            

            int newRows = random.Next(5, 15);
            int newCols = random.Next(5, 15);
            matrix1.Resize(newRows, newCols);
            Console.WriteLine($"\nmatrix1 после изменения размера ({newRows}x{newCols}):");
            matrix1.Print();

            
            Console.WriteLine("\nПодматрица matrix2 (2-я строка - 1-й столбец):");
            matrix2.PrintSubmatrix(1, 1, 0, 0);
        }
    }
    class Matrix : IComparable
    {
        private double[,] data;
        public int rows;
        public int columns;

        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("Размеры матрицы должны быть больше 0");
            }

            this.rows = rows;
            this.columns = columns;
            data = new double[rows, columns];
        }

        public double this[int row, int column]
        {
            get
            {
                if (row < 0 || row >= rows || column < 0 || column >= columns)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы матрицы");
                }

                return data[row, column];
            }
            set
            {
                if (row < 0 || row >= rows || column < 0 || column >= columns)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы матрицы");
                }

                data[row, column] = value;
            }
        }

        public void Resize(int newRows, int newColumns)
        {
            if (newRows <= 0 || newColumns <= 0)
            {
                throw new ArgumentException("Размеры матрицы должны быть больше 0");
            }

            double[,] newData = new double[newRows, newColumns];

            for (int i = 0; i < Math.Min(rows, newRows); i++)
            {
                for (int j = 0; j < Math.Min(columns, newColumns); j++)
                {
                    newData[i, j] = data[i, j];
                }
            }

            rows = newRows;
            columns = newColumns;
            data = newData;
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{data[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        public void PrintSubmatrix(int startRow, int endRow, int startColumn, int endColumn)
        {
            if (startRow < 0 || endRow >= rows || startColumn < 0 || endColumn >= columns ||
                startRow > endRow || startColumn > endColumn)
            {
                throw new ArgumentException("Неверные границы подматрицы");
            }

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startColumn; j <= endColumn; j++)
                {
                    Console.Write($"{data[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is Matrix))
            {
                throw new ArgumentException("Невозможно сравнить объект с Matrix");
            }

            Matrix otherMatrix = (Matrix)obj;

            int result = rows.CompareTo(otherMatrix.rows);
            if (result == 0)
            {
                result = columns.CompareTo(otherMatrix.columns);
            }

            return result;
        }
    }
}