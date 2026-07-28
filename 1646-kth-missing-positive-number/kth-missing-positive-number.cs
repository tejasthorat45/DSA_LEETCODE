public class Solution {
    public int FindKthPositive(int[] arr, int k) {

        // int current =1;
        // int i=0;

        // while(k>0){

        //     if(i<arr.Length && arr[i]==current){
        //         i++;

        //         //arr = [2,3,4,7,11], k = 5
        //     }else{
        //         k--;

        //         if(k==0){
        //             return current;
        //         }
        //     }

        //     current++;
        // }

       

        // return current;


        //using the BS 

        int n= arr.Length;

        int l=0;
        int r=n-1;

        while(l<=r){

            int mid = l+(r-l)/2;

            int missing_value=arr[mid]-(mid+1);


            if(missing_value<k){
                l=mid+1;
            }else{
                r=mid-1;
            }



            
        }

        return l+k;
        
    }
}