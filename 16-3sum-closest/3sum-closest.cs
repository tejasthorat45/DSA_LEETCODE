public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {

        // 1. Sort the array
        Array.Sort(nums);
        
        // 2. Initialize closestSum with the first valid triplet
        int closestSum = nums[0] + nums[1] + nums[2];
        
        // 3. Iterate with a fixed pointer 'i'
        for (int i = 0; i < nums.Length - 2; i++) {
            int left = i + 1;
            int right = nums.Length - 1;
            
            while (left < right) {
                int currentSum = nums[i] + nums[left] + nums[right];
                
                // If we find an exact match, return immediately
                if (currentSum == target) {
                    return currentSum;
                }
                
                // Update closestSum if the current one is closer to the target
                if (Math.Abs(target - currentSum) < Math.Abs(target - closestSum)) {
                    closestSum = currentSum;
                }
                
                // Move pointers based on how currentSum compares to target
                if (currentSum < target) {
                    left++;  // We need a larger sum
                } else {
                    right--; // We need a smaller sum
                }
            }
        }
        
        return closestSum;


        
    }
}