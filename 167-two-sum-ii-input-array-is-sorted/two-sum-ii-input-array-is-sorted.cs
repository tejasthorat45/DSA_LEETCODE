public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int n= nums.Length;

        int left=0;
        int right=n-1;

       


        while(left<right){

            int sum = nums[left]+nums[right];

            if(sum==target){
                return new int[]{left+1,right+1};

            }else if(sum>target){
                right--;

            }else{
                left++;

            }
        }

        return new int[]{};
        
    }
}