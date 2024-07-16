using System;
using System.Collections.Generic;
using System.IO;

public abstract class InventoryItem
{
    public string Name { get; set; }
    public double Weight { get; set; }

    protected InventoryItem(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public abstract string ToCsv();
}

public class FoodItem : InventoryItem
{
    public int Calories { get; set; }

    public FoodItem(string name, double weight, int calories) : base(name, weight)
    {
        Calories = calories;
    }

    public override string ToCsv()
    {
        return $"{Name},{Weight}kg,{Calories}kcal";
    }
}

public class WeaponItem : InventoryItem
{
    public string Size { get; set; }

    public WeaponItem(string name, double weight, string size) : base(name, weight)
    {
        Size = size;
    }

    public override string ToCsv()
    {
        return $"{Name},{Weight}kg,{Size}";
    }
}

public class MedicalItem : InventoryItem
{
    public string Potency { get; set; }

    public MedicalItem(string name, double weight, string potency) : base(name, weight)
    {
        Potency = potency;
    }

    public override string ToCsv()
    {
        return $"{Name},{Weight}kg,{Potency}";
    }
}

public class Warehouse<T> where T : InventoryItem
{
    private List<T> items = new List<T>();
    private string fileName;

    public Warehouse(string fileName)
    {
        this.fileName = fileName;
    }

    public void AddItem(T item)
    {
        items.Add(item);
        File.AppendAllText(fileName, item.ToCsv() + Environment.NewLine);
    }

    public List<T> GetItems()
    {
        return items;
    }

    public T GetItem(string name)
    {
        return items.Find(item => item.Name == name);
    }
}

class Program
{
    static void Main()
    {
        var foodWarehouse = new Warehouse<FoodItem>("food.csv");
        foodWarehouse.AddItem(new FoodItem("Apple", 0.1, 52));
        foodWarehouse.AddItem(new FoodItem("Bread", 0.5, 265));

        var weaponWarehouse = new Warehouse<WeaponItem>("weapons.csv");
        weaponWarehouse.AddItem(new WeaponItem("Sword", 3, "Large"));

        var medicalWarehouse = new Warehouse<MedicalItem>("medicine.csv");
        medicalWarehouse.AddItem(new MedicalItem("Bandage", 0.02, "50mg"));

        foreach (var food in foodWarehouse.GetItems())
        {
            Console.WriteLine(food.ToCsv());
        }

        foreach (var weapon in weaponWarehouse.GetItems())
        {
            Console.WriteLine(weapon.ToCsv());
        }

        foreach (var medical in medicalWarehouse.GetItems())
        {
            Console.WriteLine(medical.ToCsv());
        }
    }
}
