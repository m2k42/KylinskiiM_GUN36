using System;


public struct Interval
{
    private readonly Random random;
    public int Min { get; }
    public int Max { get; }

    public Interval(int minValue, int maxValue)
    {
        random = new Random();


        if (minValue < 0 || maxValue < 0)
        {
            Console.WriteLine("Incorrect input data: values cannot be negative");
            minValue = Math.Max(0, minValue);
            maxValue = Math.Max(0, maxValue);
        }


        if (minValue > maxValue)
        {
            Console.WriteLine("Incorrect input data: values are reversed");
            (minValue, maxValue) = (maxValue, minValue);
        }


        if (minValue == maxValue)
        {
            Console.WriteLine("Incorrect input data: max increased by 10");
            maxValue += 10;
        }

        Min = minValue;
        Max = maxValue;
    }

    public int Get() => random.Next(Min, Max + 1);
}



    public class Weapon
    {
        public string Name { get; }
        public Interval DamageInterval { get; }

        public float Durability { get; } = 1f;

         public Weapon(string name, Interval damageInternal)
         {
        Name = name;
        DamageInterval = damageInternal;
         }
    public Weapon(string name, int minDamage, int maxDamage) : this(name, new Interval(minDamage, maxDamage))
    {
    }

    public int GetDamage() => DamageInterval.Get();

    public override string ToString() => $"{Name} (Урон: {DamageInterval.Min}-{DamageInterval.Max}, Прочность: {Durability})";
};



public class Unit
{
    public string Name { get; }
    private float health;
    public float Health => health;
    public Interval DamageInterval { get; }
    public float Armor { get; }

    public Unit() : this("Unknown Unit", new Interval(0, 5), 0.6f)
    {
    }
    public Unit(string name) : this(name, new Interval(0, 5), 0.6f)
    {
    }


    public Unit(string name, Interval damageInterval, float armor)
    {
        Name = name;
        DamageInterval = damageInterval;
        Armor = armor;
        health = 100f;
    }
    public Unit(string name, int minDamage, int maxDamage, float armor)
        : this(name, new Interval(minDamage, maxDamage), armor)
    {
    }
    public float GetRealHealth() => Health * (1f + Armor);

    public bool SetDamage(float value)
    {
        health -= value * Armor;
        return health <= 0f;
    }

    public override string ToString() => $"{Name} (Health: {Health}, Armor: {Armor}, Damage: {DamageInterval.Min}-{DamageInterval.Max})";
}


public struct Room
{
    public Unit Unit { get; }
    public Weapon Weapon { get; }

    public Room(Unit unit, Weapon weapon)
    {
        Unit = unit;
        Weapon = weapon;
    }
}


public class Dungeon
{
    private readonly Room[] rooms;

    public Dungeon()
    {

        rooms = new Room[]
        {
            new Room(
                new Unit("warrior", new Interval(5, 10), 0.7f),
                new Weapon("sword", new Interval(8, 12))
            ),
            new Room(
                new Unit("archer", new Interval(3, 8), 0.4f),
                new Weapon("bow", new Interval(5, 15))
            ),
            new Room(
                new Unit("magician", new Interval(1, 12), 0.2f),
                new Weapon("stick", new Interval(10, 20))
            ),
            new Room(
                new Unit("Tank", new Interval(2, 6), 1.2f),
                new Weapon("Shield", new Interval(1, 4))
            )
        };
    }

    public void ShowRooms()
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            var room = rooms[i];
            Console.WriteLine($"room {i + 1}:");
            Console.WriteLine($"unit: {room.Unit}");
            Console.WriteLine($"weapon: {room.Weapon}");
            Console.WriteLine("---");
        }
    }
}


public class Program
{
    public static void Main()
    {
        Dungeon dungeon = new Dungeon();
        dungeon.ShowRooms();
    }
}