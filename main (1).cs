using System;

// Абстрактный класс Animal
abstract class Animal
{
    // Поле для имени животного
    public string Name { get; set; }

    // Поле для возраста животного
    public int Age { get; set; }

    public abstract void MakeSound();

    public abstract void Move();
}

// Класс-наследник Dog, представляющий собаку
class Dog : Animal
{
    // Реализация метода для звука собаки
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    // Реализация метода для передвижения собаки
    public override void Move()
    {
        Console.WriteLine("Dog is running");
    }
}

// Класс-наследник Cat, представляющий кошку
class Cat : Animal
{
    // Реализация метода для звука кошки
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    // Реализация метода для передвижения кошки
    public override void Move()
    {
        Console.WriteLine("Cat is walking");
    }
}

// Основной класс Program для выполнения программы
class Program
{
    static void Main(string[] args)
    {
        // Создание объекта типа Dog
        Dog dog = new Dog();
        dog.Name = "Pitbull";
        dog.Age = 3;

        // Вызов методов MakeSound и Move для объекта Dog
        Console.WriteLine($"Name: {dog.Name} | Age: {dog.Age}");
        dog.MakeSound();  // Выводит: Bark
        dog.Move();       // Выводит: Dog is running

        // Создание объекта типа Cat
        Cat cat = new Cat();
        cat.Name = "Raphael";
        cat.Age = 2;

        // Вызов методов MakeSound и Move для объекта Cat
        Console.WriteLine($"Name: {cat.Name} | Age: {cat.Age}");
        cat.MakeSound();  // Выводит: Meow
        cat.Move();       // Выводит: Cat is walking
    }
}
