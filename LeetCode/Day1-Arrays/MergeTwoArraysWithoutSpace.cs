//Merge two sorted arrays without extra space
using System.Collections;
namespace LeetCode.Arrays
{
    public class MergeTwoSortedArrays
    {
        ArrayList inputArray1;
        ArrayList inputArray2;
        public void getInput()
        {
            Console.WriteLine("Enter the number of elements in the array1");
            int maxValuesin1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the input values one by one");
            inputArray1 = new ArrayList();

            for (int index = 0; index < maxValuesin1; index++)
            {
                inputArray1.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Enter the number of elements in the array2");
            int maxValuesin2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the input values one by one");
            inputArray2 = new ArrayList();

            for (int index = 0; index < maxValuesin2; index++)
            {
                inputArray2.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }

        public void getSortedMergedArray()
        {
            inputArray1.AddRange(inputArray2);
            ArrayList mergedArrayList = new ArrayList(inputArray1);
            mergedArrayList.Sort();

            foreach (int element in mergedArrayList)
            {
                Console.WriteLine(element);
            }
        }
    }
}