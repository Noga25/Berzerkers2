//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

using System;
using static Berzerkers2.Interface;

namespace Berzerkers2
{
    public class Interface
    {
        public interface IRandomProvider
        {
            int Roll(uint min, uint max);
        }
    }

    public class Teams : IRandomProvider
    {
        private List<int> numbers;
        private int currentIndex;
        private Random random;

        public Teams(List<int> numbers)
        {
            this.numbers = numbers;
            currentIndex = 0;
            random = new Random();
            Shuffle(numbers);
        }

        public int Roll(uint min, uint max)
        {
            int result = numbers[currentIndex];
            currentIndex = (currentIndex + 1) % numbers.Count;
            return result;
        }
        private void Shuffle(List<int> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    public class Bag : IRandomProvider
    {
        private readonly List<int> numbers;
        private readonly Random random;

        public Bag(int min, int max)
        {
            numbers = Enumerable.Range(min, max - min + 1).ToList();
            random = new Random();
        }

        public int Roll(uint min, uint max)
        {
            if (numbers.Count == 0)
            {
                numbers.AddRange(Enumerable.Range((int)min, (int)(max - min + 1)));
                Shuffle(numbers);
            }

            int index = random.Next(numbers.Count);
            int number = numbers[index];
            numbers.RemoveAt(index);

            return number;
        }

        private void Shuffle(List<int> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

}
