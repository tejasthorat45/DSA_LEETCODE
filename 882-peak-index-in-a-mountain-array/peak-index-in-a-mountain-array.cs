public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {

        for(int i=0;i<arr.Length;i++){

            if(arr[i]>arr[i+1]){
                return i;
            }


        }

        return -1;
        
    }
}