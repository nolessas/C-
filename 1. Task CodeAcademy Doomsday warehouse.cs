using System;
using System.Collections.Generic;
using System.IO;

// Abstract base class
public abstract class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Weight { get; set; }

    // Constructor
    public Item(int id, string name, double weight)
    {
        Id = id;
        Name = name;
        Weight = weight;
    }

    // Abstract method to return CSV representation
    public abstract string ToCsv();
}

// Derived class for Weapons
public class Weapon : Item
{
    public Weapon(int id, string name, double weight) : base(id, name, weight)
    {
    }

    public override string ToCsv()
    {
        return $"{Id},{Name},{Weight},Weapon";
    }
}

// Derived class for Food
public class Food : Item
{
    public Food(int id, string name, double weight) : base(id, name, weight)
    {
    }

    public override string ToCsv()
    {
        return $"{Id},{Name},{Weight},Food";
    }
}

// Derived class for Aid (Medicine)
public class Aid : Item
{
    public Aid(int id, string name, double weight) : base(id, name, weight)
    {
    }

    public override string ToCsv()
    {
        return $"{Id},{Name},{Weight},Aid";
    }
}

class Program
{
    static void Main()
    {
        // Creating a list of items
        List<Item> items = new List<Item>
        {
            new Weapon(1, "Sword", 3.5),
            new Food(2, "Apple", 0.1),
            new Aid(3, "Bandage", 0.02)
        };

        // Prepare file path
        string filePath = "warehouse.csv";
        
        // Writing items to a CSV file using simple file write
        WriteItemsToCsv(filePath, items);

        // Reading items from the CSV file using simple file read
        string[] readItems = ReadItemsFromCsv(filePath);
        foreach (var item in readItems)
        {
            Console.WriteLine(item);
        }
    }

    static void WriteItemsToCsv(string filePath, List<Item> items)
    {
        List<string> lines = new List<string>();
        foreach (var item in items)
        {
            lines.Add(item.ToCsv());
        }
        File.WriteAllLines(filePath, lines);
    }

    static string[] ReadItemsFromCsv(string filePath)
    {
        return File.ReadAllLines(filePath);
    }
}
