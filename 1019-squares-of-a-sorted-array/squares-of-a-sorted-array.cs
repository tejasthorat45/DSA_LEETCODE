public class Solution {
    public int[] SortedSquares(int[] nums) {

        //brute force

        int[] ans = new int[nums.Length];
        int n = nums.Length;

        int idx=n-1;

        // foreach(int num in nums){


        //     int sq = num * num;
        //     ans[idx++]=sq;





        // }

        // Array.Sort(ans);

        // return ans;

        int left=0;
        int right=n-1;

        while(left<=right){
            int leftsq = nums[left] *nums[left];
            int rightsq = nums[right]*nums[right];

            if(leftsq>rightsq){
                ans[idx] = leftsq;
                left++;
            }else{

                 ans[idx] = rightsq;
                right--;


            }

            idx--;
        }

        return ans;
        
    }
}