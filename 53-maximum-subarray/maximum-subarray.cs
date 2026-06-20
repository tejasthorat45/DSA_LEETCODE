public class Solution {
    public int MaxSubArray(int[] nums) {

        int n = nums.Length;
        // int max=int.MinValue;

        // for(int i=0;i<n;i++){

        //     int sum=0;


        //     for(int j=i;j<n;j++){

        //         sum+=nums[j];

        //           max = Math.Max(sum,max);

        //     }

          
        // }

        // return max;

        //USING THE KADANE ALGO

        int maxsum = nums[0];
        int currentsum = nums[0];

        for(int i=1;i<n;i++){

            currentsum=Math.Max(nums[i],currentsum+nums[i]);

            maxsum = Math.Max(currentsum,maxsum);


        }

        return maxsum;
        
    }
}