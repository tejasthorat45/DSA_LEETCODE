public class Solution {
    public int[] SortedSquares(int[] nums) {

        //brute force

        int[] ans = new int[nums.Length];
        int idx=0;

        foreach(int num in nums){


            int sq = num * num;
            ans[idx++]=sq;





        }

        Array.Sort(ans);

        return ans;
        
    }
}