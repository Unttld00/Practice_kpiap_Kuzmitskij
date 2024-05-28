using System;
using System.Collections.Generic;

namespace zad2
{
    // Класс "Животное"
    public class Animal
    {
        public string Species { get; set; } // Вид
        public string Name { get; set; } // Имя
        public int Age { get; set; } // Возраст
        public double Weight { get; set; } // Вес

        public Animal(string species, string name, int age, double weight)
        {
            Species = species;
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override string ToString() => $"{Species} - {Name} ({Age} года, {Weight} кг)";
    }

    // Класс "Коллекция животных"
    public class AnimalCollection
    {
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public List<Animal> FindAnimals(Predicate<Animal> predicate)
        {
            return animals.FindAll(predicate);
        }

        public void SortAnimals(Comparison<Animal> comparison)
        {
            animals.Sort(comparison);
        }

        public void PrintAnimals(TextWriter writer)
        {
            foreach (var animal in animals)
            {
                writer.WriteLine(animal);
            }
        }
    }
}
