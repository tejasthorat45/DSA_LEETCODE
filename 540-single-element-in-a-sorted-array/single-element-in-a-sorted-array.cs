public class Solution {
    public int SingleNonDuplicate(int[] nums) {

        if(nums.Length==1)
        return nums[0];


        for(int i=1;i<nums.Length;i+=2){


            if(nums[i]!=nums[i-1]){
                return nums[i-1];
            }
        }

        return nums[nums.Length-1];



        


        
    }
}