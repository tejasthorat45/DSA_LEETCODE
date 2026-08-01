public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {



        //using the two ptr

        int left=0;
        int right=arr.Length-1;

        while(right-left+1>k){


            if(Math.Abs(arr[left]-x)<=Math.Abs(arr[right]-x)){

                right--;



            }else{
                left++;
            }


        }

        //cal the the res from window

        List<int> res = new List<int>();

        for(int i=left;i<=right;i++){

            res.Add(arr[i]);


        }

        return res;


        
        
    }
}