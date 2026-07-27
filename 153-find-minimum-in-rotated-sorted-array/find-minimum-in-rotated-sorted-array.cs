public class Solution {
    public int FindMin(int[] nums) {

        int n=nums.Length;

        int l=0;
        int r=n-1;

        while(l<r){
            int mid =l+(r-l)/2;

            if(nums[mid]>nums[r]){

                l=mid+1;
            }else{
                r=mid;
            }
        }

        return nums[l];

        
    }
}