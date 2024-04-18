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
        double FuelPricePerLitr =Convert.ToDouble(Console.ReadLine());
        double DrivePrice = (DachaDistance / 100) * CarConsupmption * FuelPricePerLitr;
        Console.WriteLine("Стоимость поездки равна " + DrivePrice);
    }










    }
}
