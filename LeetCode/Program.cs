/// <summary>
/// MainProgram contains Main() method for all relevant classes to be tested.
/// </summary>
using LeetCode.Arrays;

public class Program
{
    public static void Main(string[] args)
    {
        MergeOverlappingIntervals ob = new MergeOverlappingIntervals();
        ob.getInput();
        ob.sortInputValues();
        ob.getMaximumOverLappingSubIntervals();
    }
}