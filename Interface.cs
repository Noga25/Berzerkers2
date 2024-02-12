//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

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

        public Bag(List<int> numbers)
        {
            this.numbers = numbers;
            currentIndex = 0;
        }

        public int Roll(uint min, uint max)
        {
            int result = numbers[currentIndex];
            currentIndex = (currentIndex + 1) % numbers.Count;
            return result;
        }
    }

}
