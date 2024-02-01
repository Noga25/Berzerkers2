//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    interface IRandomProvider
    {
        int Roll(int min, int max);
    }

    public class Bag 
    {
        private List<int> bag;
        private int currentIndex = 0;

        public Bag(List<int> numbers)
        {
            bag = new List<int>(numbers);
            Shuffle();
        }

        public int Roll(int min, int max)
        {
            if (currentIndex >= bag.Count)
            {
                Shuffle();
                currentIndex = 0;
            }

            int result = bag[currentIndex];
            currentIndex++;
            return result;
        }

        private void Shuffle()
        {
            Random rng = new Random();
            int n = bag.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = bag[k];
                bag[k] = bag[n];
                bag[n] = value;
            }
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
        // Propreties
        public virtual int HP { get; set; } = 100;
        public virtual Race UnitRace { get; }
        public virtual int CarryingCapacity { get; } = Random.Shared.Next(1, 20);
        protected virtual Dice Damage { get; } = new Dice(2, 7, -1);
        public virtual Dice HitChance { get; } = new Dice(2, 8, -1);
        public virtual Dice DefenseRating { get; } = new Dice(1, 6, 1);
        public abstract void WeatherEffect(Weather weather);

        // Methods
        public abstract void Attack(Unit target);
        public abstract void Defend(Unit attacker);
    }
}
