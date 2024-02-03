//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

using System.Collections.Generic;

namespace Berzerkers2
{
    public interface IRandomProvider
    {
        int Roll(int min, int max);
    }

    public class Bag : IRandomProvider
    {
        private List<int> numbers;
        private int currentIndex;

        public Bag(List<int> numbers)
        {
            this.numbers = numbers;
            currentIndex = 0;
        }

        public int Roll(int min, int max)
        {
            int result = numbers[currentIndex];
            currentIndex = (currentIndex + 1) % numbers.Count;
            return result;
        }
    }
    

    public struct Dice : IRandomProvider
    {
        public uint Scalar;
        public uint BaseDie;
        public int Modifier;

        public Dice(uint scalar, uint baseDie, int modifier)
        {
            Scalar = scalar;
            BaseDie = baseDie;
            Modifier = modifier;
        }

        public int Roll(int min, int max)
        {
            Random random = new Random();
            int result = 0;

            for (int i = 0; i < Scalar; i++)
            {
                result += random.Next(min, max + 1);
            }

            return result + Modifier;
        }

        public override string ToString()
        {
            return $"{Scalar}d{BaseDie}";
        }

        public override int GetHashCode()
        {
            // A simple hash combining the values
            int hash = 17;
            hash = hash * 23 + Scalar.GetHashCode();
            hash = hash * 23 + BaseDie.GetHashCode();
            hash = hash * 23 + Modifier.GetHashCode();
            return hash;
        }
    }

    // Enum of the race
    public enum Race
    {
        Human,
        Orc,
        Elf
    }

    // Enum of the Weather
    public enum Weather
    {
        Rainy,
        Stormy,
        Sunny
    }

    public interface IUnit 
    {
        void Attack(Unit target);
        void Defend(Unit attacker);
    }

    public abstract class Unit : IUnit
    {
        //Implement random provider to unit
        //protected IRandomProvider randomProvider;

        //protected Unit(IRandomProvider randomProvider)
        //{
        //    this.randomProvider = randomProvider;
        //}

        // Propreties
        public virtual int HP { get; set; } = 100;
        public virtual Race UnitRace { get; }
        public virtual int CarryingCapacity { get; } = Random.Shared.Next(1, 20);
        protected virtual IRandomProvider Damage { get; } = new Dice(2, 7, -1);
        public virtual IRandomProvider HitChance { get; } = new Dice(2, 8, -1);
        public virtual IRandomProvider DefenseRating { get; } = new Dice(1, 6, 1);
        public abstract void WeatherEffect(Weather weather);

        // Methods
        public abstract void Attack(Unit target);
        public abstract void Defend(Unit attacker);
    }
}
