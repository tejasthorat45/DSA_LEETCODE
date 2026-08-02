public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {



        //using the two ptr

        // int left=0;
        // int right=arr.Length-1;

        // while(right-left+1>k){


        //     if(Math.Abs(arr[left]-x)<=Math.Abs(arr[right]-x)){

        //         right--;



        //     }else{
        //         left++;
        //     }


        // }

        // //cal the the res from window

        // List<int> res = new List<int>();

        // for(int i=left;i<=right;i++){

        //     res.Add(arr[i]);


        // }

        // return res;


        //udsinng the Binary search

        //Input: arr = [1, 2, 3, 4, 5], k = 4, x = 3
        //              l,m  r 
        int l=0;
        int r=arr.Length-k;

        while(l<r){


            int mid = l+(r-l)/2;

            if(x-arr[mid]>arr[mid+k]-x){
                l=mid+1;

            }else{
                r=mid;
            }
        }

        List<int> res = new List<int>();

        for(int i=l;i<l+k;i++){

            res.Add(arr[i]);
        }

        return res;




        
        
    }
}