public class Solution {
    public int[] SortArrayByParity(int[] nums) {

        // int[] ans = new int[nums.Length];
        // int idx=0;
        // int odd = ans.Length-1;


        // for(int i=0;i<nums.Length;i++){

        //     if(nums[i]%2==0){
        //         ans[idx++]=nums[i];
        //     }else{
        //         ans[odd--]=nums[i];
        //     }
        // }

        // return ans;

        //using the twpo ptr

        int left =0;
        int right=nums.Length-1;

        while(left<right){

            while(left<right && nums[left]%2==0) //stop at odd no
            left++;

            while(left<right && nums[right]%2!=0) //stop at even no
            right--;

            //swap them
            if(left<right){
                int temp = nums[left];
                nums[left]=nums[right];
                nums[right]=temp;

                left++;
                right--;
            }


            
        }

        return nums;



        
    }
}