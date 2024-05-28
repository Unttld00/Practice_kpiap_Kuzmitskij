
using zad2;


AnimalCollection animals = new AnimalCollection();


animals.AddAnimal(new Animal("Собака", "Шарик", 3, 25));
animals.AddAnimal(new Animal("Кошка", "Мурзик", 5, 4));
animals.AddAnimal(new Animal("Попугай", "Кеша", 2, 0.2));


List<Animal> birds = animals.FindAnimals(animal => animal.Species == "Птица");


animals.SortAnimals((a1, a2) => a1.Name.CompareTo(a2.Name));


animals.PrintAnimals(Console.Out);