namespace Задание1
{
    internal class Program
    {
    static void Main()
    {
        Console.WriteLine("Введите расстояние до дачи: ");

        int DachaDistance = int.Parse(Console.ReadLine());
        Console.WriteLine("Потребляемое автомобилем колво бензина на 100 км: ");
        int CarConsupmption = int.Parse(Console.ReadLine());
        Console.WriteLine("Цена литра бензина: ");
        double FuelPricePerLitr = int.Parse(Console.ReadLine());
        double DrivePrice = (DachaDistance / CarConsupmption) * FuelPricePerLitr;
        Console.WriteLine("Стоимость поездки равна " + DrivePrice);
    }










    }
}
