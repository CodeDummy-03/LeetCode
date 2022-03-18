//Merge Overlapping Sub-intervals

namespace LeetCode.Arrays
{
    public class MergeOverlappingIntervals
    {
        List<intervalInput> inputArray;
        public void getInput()
        {
            Console.WriteLine("Enter the number of pairs in the array");
            int maxValues = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the start and end values one by one");
            inputArray = new List<intervalInput>();

            for (int index = 0; index < maxValues; index++)
            {
                inputArray.Add(new intervalInput());
                inputArray[index].startVal = Convert.ToInt32(Console.ReadLine());
                inputArray[index].endVal = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void sortInputValues()
        {
            for (int outerIndex = 0; outerIndex < inputArray.Count; outerIndex++)
            {
                for (int innerIndex = 0; innerIndex < inputArray.Count-1; innerIndex++)
                {
                    if (inputArray[innerIndex].startVal > inputArray[innerIndex + 1].startVal)
                    {
                        int temp = inputArray[innerIndex].startVal;
                        inputArray[innerIndex].startVal = inputArray[innerIndex + 1].startVal;
                        inputArray[innerIndex + 1].startVal = temp;
                    }
                }
            }
        }

        public void getMaximumOverLappingSubIntervals()
        {
            //1.2  3.4  5.6  5.7
            for (int i = 0; i < inputArray.Count-1; i++)
            {
                if((inputArray[i].startVal<= inputArray[i+1].startVal)&& (inputArray[i].endVal >= inputArray[i + 1].startVal))
                {
                    var compositeInput = new intervalInput() 
                    {
                        startVal = inputArray[i].startVal,
                        endVal = inputArray[i+1].endVal,
                    };
                    var firstVal = inputArray[i];
                    var secondVal = inputArray[i + 1];
                    inputArray.Remove(firstVal);
                    inputArray.Remove(secondVal);
                    inputArray.Add(compositeInput);
                }
            }

            for (int i = 0; i < inputArray.Count; i++)
            {
                Console.WriteLine(inputArray[i].startVal + ":" + inputArray[i].endVal);
            }
        }
    }

    public class intervalInput
    {
        public int startVal { get; set; }
        public int endVal { get; set; }
    }
}