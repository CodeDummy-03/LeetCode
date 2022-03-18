//Sort an array of 0’s 1’s without using extra space or sorting algo
namespace LeetCode.Arrays
{
    public class ZeroOneArraySortingWithoutSorting
    {
        int numberOfZeroes;
        int numberOfOnes;

        public void getInputAndCalculateNumberOfZeroAndTwos()
        {
            Console.WriteLine("Enter the number of elements in the array");
            int maxValues = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the input values one by one");

            for (int index = 0; index < maxValues; index++)
            {
               int value = Convert.ToInt32(Console.ReadLine());
                if(value.Equals(0))
                    numberOfZeroes++;
                else
                    numberOfOnes++;
            }
        }

        public void printArrayOfZeroAndTwos()
        {
            for (int index = 0; index < numberOfZeroes + numberOfOnes; index++)
            {
                if (index < numberOfZeroes)
                    Console.Write("0 ");
                else
                    Console.Write("1 ");
            }
        }
    }
}