public class Solution {
    public int[] SearchRange(int[] nums, int target) {

        int first =-1;
        int last=-1;

        for(int i=0;i<nums.Length;i++){


            if(nums[i]==target){

                if(first==-1)
                first=i;

                last=i;
            }
        }  

        return new int[] {first,last}     ;
    }
}