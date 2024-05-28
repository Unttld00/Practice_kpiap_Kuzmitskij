using System;
using System.Collections.Generic;


    public abstract class Plant
    {
        public string Species { get; set; } // Вид
        public double Height { get; set; } // Высота
        public string Color { get; set; } // Цвет
        public PlantType Type { get; set; } // Тип

        public enum PlantType
        {
            Flower,
            Tree,
            Bush
        }

        public Plant(string species, double height, string color, PlantType type)
        {
            Species = species;
            Height = height;
            Color = color;
            Type = type;
        }

        public override string ToString() => $"{Species} ({Height} м, {Color}, {Type})";

        public abstract Plant Clone();
    }

    // Класс "Цветок"
    public class Flower : Plant
    {
        public Flower(string species, double height, string color) : base(species, height, color, PlantType.Flower) { }

        public override Plant Clone() => new Flower(Species, Height, Color);
    }

    // Класс "Дерево"
    public class Tree : Plant
    {
        public Tree(string species, double height, string color) : base(species, height, color, PlantType.Tree) { }

        public override Plant Clone() => new Tree(Species, Height, Color);
    }

    // Класс "Кустарник"
    public class Bush : Plant
    {
        public Bush(string species, double height, string color) : base(species, height, color, PlantType.Bush) { }

        public override Plant Clone() => new Bush(Species, Height, Color);
    }

    // Класс-прототип "Коллекция растений"
    public class PlantCollection<T> where T : Plant
    {
        private List<T> plants = new List<T>();

        public void AddPlant(T plant)
        {
            plants.Add(plant);
        }

        public List<T> FindPlants(Predicate<T> predicate)
        {
            return plants.FindAll(predicate);
        }

        public void SortPlants(Comparison<T> comparison)
        {
            plants.Sort(comparison);
        }

        public void PrintPlants(TextWriter writer)
        {
            foreach (var plant in plants)
            {
                writer.WriteLine(plant);
            }
        }
    }


class Program
{
    static void Main()
    {
        PlantCollection<Plant> plantCollection = new PlantCollection<Plant>();

        // Добавление растений
        plantCollection.AddPlant(new Flower("Роза", 0.5, "Красный"));
        plantCollection.AddPlant(new Tree("Дуб", 20, "Зеленый"));
        plantCollection.AddPlant(new Bush("Сирень", 3, "Фиолетовый"));

        // Поиск цветов по цвету
        List<Plant> redFlowers = plantCollection.FindPlants(plant => plant.Color == "Красный");

        // Сортировка деревьев по высоте
        plantCollection.SortPlants((t1, t2) => t1.Height.CompareTo(t2.Height));

        // Печать информации о растениях в консоль
        plantCollection.PrintPlants(Console.Out);

        // Клонирование растения
        Plant roseClone = redFlowers[0].Clone();
        Console.WriteLine($"Клон розы: {roseClone}");
    }
}
