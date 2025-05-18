
    internal class Program
        {
            static void Main(string[] args)
            {
               
            }
        }

namespace Weapon
{
    public class Weapon
    {
        public string Name
        {
            get;
        }


        public int MinDamage
        {
            get; private set;

        }

        public int MaxDamage
        {
            get; private set;

        }

        public float Durability { get; } = 1f;

        public Weapon(string name)
        {
            Name = name;
        }
        public void SetDamageParams(int minDamage, int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                (minDamage, maxDamage) = (maxDamage, minDamage);
                Console.WriteLine("Incorrect input data for weapons '" + Name + "'");
            }
            if (minDamage < 1)
            {
                minDamage = 1;
                Console.WriteLine("For weapon '" + Name + "' the minimum damage value has been set - 1");
            }
            if (maxDamage <= 1)
            {
                maxDamage = 10;
                Console.WriteLine("For weapon '" + Name + "' the maximum damage value has been set (10)");
            }
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
        public int GetDamage()
        {
            return (MinDamage + MaxDamage) / 2;
        }
        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }
    };


}
