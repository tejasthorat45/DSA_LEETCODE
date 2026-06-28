public class Solution {
    public int RemoveElement(int[] nums, int val) {

        // int k=0;
        // for(int i=0;i<nums.Length;i++){

        //     if(nums[i]!=val){

        //         nums[k++]=nums[i];
        //     }
        // }

        // return k;

        //more optimal using the two pte

        int left=0;
        int right=nums.Length-1;

        while(left<=right){

            //check the eleemnt 
            if(nums[left]==val){
                nums[left]=nums[right];
                right--;
            }else{
                left++;
            }

        }

        return right+1;



        
        
    }
}