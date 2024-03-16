using System.Diagnostics;

namespace ArrayTestWithGPT
{
    internal class Program
    {
        public static int[] intNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        static void Main(string[] args)
        {
            int evenSum = EvenNumsSum();
            int oddSum = OddNumsSum();

            Console.WriteLine($"모든 짝수들의 합은 {evenSum}, 모든 홀수들의 합은 {oddSum}");
        }

        public static int EvenNumsSum()
        {
            int evenNumSum = 0;
            for (int i = 0; i < intNums.Length; i++)
            {
                if (intNums[i] % 2 == 0)
                {
                    evenNumSum += intNums[i];
                }
            }

            return evenNumSum;
        }

        public static int OddNumsSum()
        {
            int oddNumSum = 0;
            for (int i = 0; i < intNums.Length; i++)
            {
                if (intNums[i] % 2 == 1)
                {
                    oddNumSum += intNums[i];
                }
            }

            return oddNumSum;
        }
    }
}
