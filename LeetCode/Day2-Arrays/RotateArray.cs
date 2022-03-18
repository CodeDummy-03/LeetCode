using System;
using System.Collections;

namespace LeetCode.Arrays
{
    public class RotateArray
    {
        ArrayList inputArray;
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

        public void getRotatedArray()
        {
            inputArray.Reverse();
            foreach (int element in inputArray)
            {
                Console.Write(element+" ");
            }
        }
    }
}