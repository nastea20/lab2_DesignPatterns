using System;
using System.Collections.Generic;

// Metoda Singleton
public class GymManager
{
    private static GymManager _instance;
    private GymManager() { }

    public static GymManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GymManager();
            }
            return _instance;
        }
    }
}

// Metoda Prototype
public abstract class EquipmentPrototype
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public abstract EquipmentPrototype Clone();
}

public class Equipment : EquipmentPrototype
{
    public override EquipmentPrototype Clone()
    {
        return (EquipmentPrototype)this.MemberwiseClone();
    }
}

public class Coach
{
    public string Name { get; set; }
}

public class Gym
{
    public List<EquipmentPrototype> Equipment { get; set; }
    public List<Coach> Coaches { get; set; }

    public Gym()
    {
        Equipment = new List<EquipmentPrototype>();
        Coaches = new List<Coach>();
    }
}

// Metoda Builder
public class GymBuilder
{
    private Gym _gym;

    public GymBuilder()
    {
        _gym = new Gym();
    }

    public GymBuilder AddEquipment(EquipmentPrototype equipment, int quantity)
    {
        var clonedEquipment = equipment.Clone();
        clonedEquipment.Quantity = quantity;
        _gym.Equipment.Add(clonedEquipment);
        return this;
    }

    public GymBuilder HireCoach(Coach coach)
    {
        _gym.Coaches.Add(coach);
        return this;
    }

    public Gym Build()
    {
        return _gym;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Utilizare Singleton
        var gymManager = GymManager.Instance;

        // Utilizare Prototype
        var equipmentPrototype = new Equipment() { Name = "Bench Press" };
        var equipmentClone = equipmentPrototype.Clone();
        Console.WriteLine($"Equipment name: {equipmentClone.Name}, quantity: {equipmentClone.Quantity}");

        // Utilizare Builder
        var gymBuilder = new GymBuilder()
            .AddEquipment(new Equipment() { Name = "Treadmill" }, 5)
            .HireCoach(new Coach() { Name = "John Doe" });

        var gym = gymBuilder.Build();
        Console.WriteLine($"The gym has {gym.Equipment.Count} pieces of equipment and {gym.Coaches.Count} coaches.");
    }
}
