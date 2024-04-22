namespace task2
{
    using System;

    class Ship
    {
        public string Name { get; set; }
        public int YearBuilt { get; set; }

        public Ship(string name, int yearBuilt)
        {
            Name = name;
            YearBuilt = yearBuilt;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Корабль: {Name}, Год выпуска: {YearBuilt}");
        }
    }

    class Steamship : Ship
    {
        public int SteamPower { get; set; }

        public Steamship(string name, int yearBuilt, int steamPower) : base(name, yearBuilt)
        {
            SteamPower = steamPower;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Мощность : {SteamPower}");
        }
    }

    class SailingShip : Ship
    {
        public int MastCount { get; set; }

        public SailingShip(string name, int yearBuilt, int mastCount) : base(name, yearBuilt)
        {
            MastCount = mastCount;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Колличество мачт : {MastCount}");
        }
    }

    class Corvette : SailingShip
    {
        public int Cannons { get; set; }

        public Corvette(string name, int yearBuilt, int mastCount, int cannons) : base(name, yearBuilt, mastCount)
        {
            Cannons = cannons;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Колличество пушек: {Cannons}");
        }
    }

    class Program
    {
        static void Main()
        {
         
            Ship ship = new Ship("Венера", 1800);
            ship.PrintInfo();

            Steamship steamship = new Steamship("Титаник", 1912, 1000);
            steamship.PrintInfo();

            SailingShip sailingShip = new SailingShip("Клевер", 1620, 3);
            sailingShip.PrintInfo();

            Corvette corvette = new Corvette("Победа", 1765, 3, 104);
            corvette.PrintInfo();
        }
    }
}