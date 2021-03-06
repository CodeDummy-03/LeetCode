//Find the duplicate element in an array of N elements.
using System.Collections;

namespace LeetCode.Arrays
{
    public class DuplicateNumber_s_
    {
        ArrayList inputArray;
        HashSet<int> duplicateElements;
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

        public void sortInputs()
        {
            inputArray.Sort();
        }

        public void getDuplicateElements()
        {
            sortInputs();
            duplicateElements = new HashSet<int>();
            for (int index = 0; index < inputArray.Count; index++)
            {
                int value = Convert.ToInt32(inputArray[index]);
                inputArray.Remove(value);
                if (inputArray.Contains(value))
                {
                    duplicateElements.Add(value);
                }
            }

            foreach (int value in duplicateElements)
            {
                Console.WriteLine(value);
            }
        }
    }
}