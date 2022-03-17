//Missing Number - Assunption: 1 number missing in a list of -1- differeces each
using System.Collections;

namespace LeetCode.Arrays
{
    public class MissingNumber
    {
        ArrayList inputArray;

        public void getSortedInput()
        {
            Console.WriteLine("Enter the number of elements in the array");
            int maxValues = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the input values one by one");
            inputArray = new ArrayList();

            for (int index = 0; index < maxValues; index++)
            {
                inputArray.Add(Convert.ToInt32(Console.ReadLine()));
            }
            inputArray.Sort();
        }

        public void getMissingNumber()
        {
            for (int index = 0; index < inputArray.Count - 1; index++)
            {
                if (Convert.ToInt32(inputArray[index + 1]) - Convert.ToInt32(inputArray[index + 1]) != 1)
                {
                    Console.WriteLine(Convert.ToInt32(inputArray[index])+ 1);
                    break;
                }
            }
        }
    }
}