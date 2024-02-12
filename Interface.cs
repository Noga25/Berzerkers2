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

    public class Bag : IRandomProvider
    {
        private List<int> numbers;
        private int currentIndex;
        private Random random;

        public Bag(List<int> numbers)
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

}
