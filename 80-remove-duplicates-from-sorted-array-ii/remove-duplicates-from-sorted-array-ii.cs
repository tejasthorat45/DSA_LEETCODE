public class Solution {
    public int RemoveDuplicates(int[] nums) {

        // if(nums.Length<=2)
        // return nums.Length;

        // //brute force using the extra array

        // int[] ans = new int[nums.Length];

        // ans[0] =nums[0];
        // ans[1]= nums[1];

        // int idx=2;

        // for(int i=2;i<nums.Length;i++){

        //     if(nums[i]!=ans[idx-2]){

        //         //unoiqe 2 element

        //         ans[idx]=nums[i];
        //         idx++;

        //     }

        // }

        // //copy to real array

        // for(int j=0;j<=idx;j++){

        //     nums[j]=ans[j];
        // }


        // return idx;

        
      int i = 0;

        foreach (int num in nums)
        {
            if (i < 2 || num != nums[i - 2])
            {
                nums[i] = num;
                i++;
            }
        }

        return i;

    }
}