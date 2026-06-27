public class Solution {
    public int MaxArea(int[] height) {
        
        // //brute force 
        // int maxwater =0;

        // for(int i=0;i<height.Length;i++){

        //     for(int j=i+1;j<height.Length;j++){

              

        //         int len=j-i;

        //         int b = Math.Min(height[i],height[j]);

        //         maxwater = Math.Max(maxwater,len*b);
        //     }
        // }

        // return maxwater;

        //optimal using two ptr

        int maxwater=0;
        int left=0;
        int right=height.Length-1;

        while(left<right){

            int len = Math.Min(height[left],height[right]);

            int b = right-left;

            maxwater=Math.Max(maxwater,len*b);

            //move ptr with smaller h

            if(len==height[left]){
                left++;
            }else{
                right--;
            }
        }

        return maxwater;
    }
}