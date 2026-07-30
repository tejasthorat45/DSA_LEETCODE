public class Solution {
    public int SingleNonDuplicate(int[] nums) {

        // if(nums.Length==1)
        // return nums[0];


        // for(int i=1;i<nums.Length;i+=2){


        //     if(nums[i]!=nums[i-1]){
        //         return nums[i-1];
        //     }
        // }

        // return nums[nums.Length-1];


        //using the binary search

        int l=0;
        int r=nums.Length-1;

        while(l<r){


            int mid = l+(r-l)/2;

            if(mid%2==1)
            mid--;

            if(nums[mid]==nums[mid+1]){
                l=mid+2;
            }else{
                r=mid;
            }
        }

        return nums[r];



        


        
    }
}