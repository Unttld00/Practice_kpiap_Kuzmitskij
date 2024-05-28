namespace zad2
{
    class Program
    {
        static void Main()
        {
            Task[] tasks = new Task[2];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(2000);
                double alpha = 0.5;
                double z1 = (Math.Cos(alpha) + Math.Cos(2* alpha) + Math.Cos(6 * alpha) + +Math.Cos(7 * alpha));
                Console.WriteLine("Задача 1 завершена, z1 = " + z1);
            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                double alpha = 0.5;
            double z2 = (4 * Math.Cos(alpha/2) * Math.Cos((5/ 2) * alpha) * Math.Cos(4 * alpha ));
                Console.WriteLine("Задача 2 завершена, z2 = " + z2);
            });

            Task.WhenAll(tasks).Wait();
            Console.WriteLine("Все задачи завершены");


        }
    }
}
