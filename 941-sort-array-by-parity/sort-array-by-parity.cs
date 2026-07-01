public class Solution {
    public int[] SortArrayByParity(int[] nums) {

        int[] ans = new int[nums.Length];
        int idx=0;
        int odd = ans.Length-1;


        for(int i=0;i<nums.Length;i++){

            if(nums[i]%2==0){
                ans[idx++]=nums[i];
            }else{
                ans[odd--]=nums[i];
            }
        }

        return ans;


        
    }
}