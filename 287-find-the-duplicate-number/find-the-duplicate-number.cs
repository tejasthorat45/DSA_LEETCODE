public class Solution {
    public int FindDuplicate(int[] nums) {

        // //O(nlogn)

        // Array.Sort(nums);

        // for(int i=1;i<nums.Length;i++){

        //     if(nums[i]==nums[i-1]){
        //         return nums[i];
        //     }

        // }

        // return 0;

        //using fast and slow ptr

        int slow =nums[0];
        int fast=nums[0];

        slow=nums[slow];
        fast=nums[nums[fast]];

        while(slow != fast){
            slow=nums[slow];
            fast=nums[nums[fast]];


        }

        //detect the cycle 
        slow=nums[0];

        while(slow!=fast){
            slow=nums[slow];
            fast=nums[fast];
        }

        return slow;
        
    }
}