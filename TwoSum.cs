
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // iterates over each element in array, i as the index
        for (int i = 0; i < nums.Length; i++)
        {
            // iterates over each element, starting from the element following current element of the outer loop
            for (int s = i + 1; s < nums.Length; s++)
            {
                // if sum of two selected elements is equal to target
                if (nums[i] + nums[s] == target)
                {
                    // return indices
                    return new int[] { i, s };
                }
            }
        }
        // In case no solution is found
        return null;
    }
}