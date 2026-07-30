public class Solution {
    public int MySqrt(int x) {

        // //brtute force 

        // //base case

        // if(x==0)
        // return 0;

        // long i=1;
        // while(i*i<=x){
        //     i++;
        // }

        // return (int)(i-1);

        int left=0;
        int right=x;

        int ans = 0;

        while(left<=right){

            int mid = left+(right-left)/2;

            long sqrt = (long)mid*mid;
            if(sqrt==x){
                return mid;
            }
            else if(sqrt<x){
                left=mid+1;
                ans=mid;
            }else{
                right=mid-1;
            }
        }

        return ans;






        
    }
}