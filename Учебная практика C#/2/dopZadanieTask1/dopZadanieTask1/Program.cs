namespace dopZadanieTask1
{
    using System;
    using System.Threading.Channels;

    class Room
    {
        private double area;
        private double height;
        private double windowCount;

        public double Area
        {
            get { return area; }
            set
            {
                if (value > 0)
                    area = value;
                else
                    throw new ArgumentException("Метраж должен быть больше чем 0.");
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    throw new ArgumentException("Высота комнаты должна быть больше чем 0.");
            }
        }

        public double WindowCount
        {
            get { return windowCount; }
            set
            {
                if (value >= 0)
                    windowCount = value;
                else
                    throw new ArgumentException("Колличество окон не может быть отрицательным.");
            }
        }

        public Room(double area, double height, double windowCount)
        {
            Area = area;
            Height = height;
            WindowCount = windowCount;
        }

        public double CalculateVolume()
        {
            return Area * Height;
        }

       
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите метраж комнаты: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту комнаты: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите колличество окон в комнате: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Room room = new Room(a, b, c);

            Console.WriteLine($"Площадь комнаты: {room.Area} квадратных метров");
            Console.WriteLine($"Высота комнаты: {room.Height} метров");
            Console.WriteLine($"Колличество окон: {room.WindowCount}");
            Console.WriteLine($"Обьем комнаты: {room.CalculateVolume()} кубометров");
            
        }
    }

}