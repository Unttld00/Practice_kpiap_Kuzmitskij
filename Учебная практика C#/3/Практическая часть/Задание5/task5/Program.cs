namespace task5
{
    using System;

    class Airplane
    {
        private string destination;
        private int flightNumber;
        private DateTime departureTime;

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }

        
        public Airplane()
        {
            destination = "Не указано";
            flightNumber = 0;
            departureTime = DateTime.MinValue;
        }

        
        public Airplane(string destination, int flightNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.flightNumber = flightNumber;
            this.departureTime = departureTime;
        }

       
        public void PrintInfo()
        {
            Console.WriteLine($"Пункт назначения: {destination}");
            Console.WriteLine($"Номер рейса: {flightNumber}");
            Console.WriteLine($"Время отправления: {departureTime}");
        }

        
        public override string ToString()
        {
            return $"Пункт назначения: {destination}, Номер рейса: {flightNumber}, Время отправления: {departureTime}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите город назначения: ");
            string City = Console.ReadLine();
            Console.WriteLine("Введите номер полета: ");
            int flight_numb = Convert.ToInt32(Console.ReadLine());
            
            DateTime flightDate = new DateTime(2024, 12, 31, 18, 30, 0);

            Airplane plane1 = new Airplane(City, flight_numb, flightDate);
            plane1.PrintInfo();

            Airplane plane2 = new Airplane();
            plane2.PrintInfo();

            Console.WriteLine(plane1);
            Console.WriteLine(plane2);
        }
    }
}