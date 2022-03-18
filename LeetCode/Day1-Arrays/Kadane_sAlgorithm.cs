//Maximum Subarray - Kadane’s Algorithm
using System.Collections;

namespace LeetCode.Arrays
{
    public class Kanade_sAlgorithm
    {
        ArrayList inputArray;
        Dictionary<int, ArrayList> sumAndArrayList;
        public void getInput()
        {
            Console.WriteLine("Enter the number of elements in the array");
            int maxValues = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the input values one by one");
            inputArray = new ArrayList();

            for (int index = 0; index < maxValues; index++)
            {
                inputArray.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }

        public void getMaximumSubArray()
        {
            sumAndArrayList = new Dictionary<int, ArrayList> ();
            for (int outerIndex = 0; outerIndex < inputArray.Count; outerIndex++)
            {
                int sum = 0;
                ArrayList array = new ArrayList();
                for (int innerIndex = 0; innerIndex <= outerIndex; innerIndex++)
                {
                    sum += Convert.ToInt32(inputArray[innerIndex]);
                    array.Add(Convert.ToInt32(inputArray[innerIndex]));
                }
                sumAndArrayList.Add(sum, array);
            }

            foreach (int value in sumAndArrayList[sumAndArrayList.Keys.Max()])
            {
                Console.WriteLine(value);
            }
        }
    }
}