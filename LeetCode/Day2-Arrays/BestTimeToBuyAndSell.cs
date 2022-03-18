using System.Collections;

namespace LeetCode.Arrays
{
    public class BestTimeToBuyAndSell
    {
        Stack inputArray;

        public int bestBuy { get; set; }
        public int bestSell { get; set; }

        public void getInput()
        {
            Console.WriteLine("Enter the number of elements in the array");
            int maxValues = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the input values one by one");
            inputArray = new Stack();
            bestBuy = 0;
            bestSell = 0;
            for (int index = 0; index < maxValues; index++)
            {
                inputArray.Push(Convert.ToInt32(Console.ReadLine()));
            }
        }

        public void getBestToVuyAndSell()
        {
            for(int index=0;index<inputArray.Count;index++)
            {
                var buyVal = Convert.ToInt32(inputArray.Pop());
                var sellVal = Convert.ToInt32(inputArray.ToArray().Max());
                if (buyVal < sellVal)
                {
                    if ((sellVal - buyVal) > (bestSell - bestBuy))
                    {
                        bestBuy = buyVal;
                        bestSell = sellVal;
                    }
                }
            }

            Console.WriteLine(bestBuy + ":" + bestSell);
        }
    }
}