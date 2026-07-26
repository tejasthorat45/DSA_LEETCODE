public class Solution {
    public int SearchInsert(int[] nums, int target) {

        //brute force

        // for(int i=0;i<nums.Length;i++){


        //     if(target<=nums[i]){
        //         return i;
        //     }

        // }
        // return nums.Length;

        //binary searchb

        int left=0;
        int right=nums.Length-1;

        while(left<=right){

            int mid = left+(right-left)/2;

            if(target==nums[mid]){
                return mid;
            }

            if(nums[mid]<target){
                left=mid+1;
            }else{
                right=mid-1;
            }


        }

        return left;




        
    }
}