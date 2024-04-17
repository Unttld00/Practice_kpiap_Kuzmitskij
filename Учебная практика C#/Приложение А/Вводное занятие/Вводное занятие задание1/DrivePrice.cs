namespace N1
{
    


class Program
{

static void main()
{ 
Console.WriteLine("Введите расстояние до дачи: ");  
int DachaDistance = int.Parse(Console.Readline());
Console.WriteLine("Потребляемое автомобилем колво бензина на 100 км: ")  ;  
int CarConsupmption = int.Parse(Console.Readline());
Console.WriteLine("Цена литра бензина: ") ;   
int FuelPricePerLitr = int.Parse(Console.Readline());
DrivePrice = (DachaDistance / CarConsupmption) * FuelPricePerLitr;
Console.WriteLine("Стоимость поездки равна ", DrivePrice);






}

}



}