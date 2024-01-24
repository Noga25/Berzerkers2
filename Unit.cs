//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Berzerkers2
{
    public struct Dice
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

        public int Roll()
        {
            Random random = new Random();
            int result = 0;

            for (int i = 0; i < Scalar; i++)
            {
                result += random.Next(1, (int)BaseDie + 1);
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

    public abstract class Unit
    {
        // Existing attributes
        public virtual int HP { get; set; } = 100;
        public virtual Race UnitRace { get; }
        public abstract int CarryingCapacity { get; }
        protected abstract Dice Damage { get; }
        public abstract Dice HitChance { get; }
        public abstract Dice DefenseRating { get; }
        public abstract void WeatherEffect(Weather weather);

        // Methods
        public abstract void Attack(Unit target);
        public abstract void Defend(Unit attacker);
    }
}
