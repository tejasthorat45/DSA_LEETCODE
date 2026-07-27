public class Solution {
    public int[] SearchRange(int[] nums, int target) {

        // int first =-1;
        // int last=-1;

        // for(int i=0;i<nums.Length;i++){


        //     if(nums[i]==target){

        //         if(first==-1)
        //         first=i;

        //         last=i;
        //     }
        // }  

        // return new int[] {first,last}     ;

        int n= nums.Length;

        int left_most = findfirst(nums,target,n);

        if(left_most==-1){
            return new int[] {-1,-1};
        }

        int right_most= findlast(nums,target,n);

        return new int[] {left_most,right_most};



    }

    private int findfirst(int[] nums,int target,int n){


        //use bs 

        int l=0;
        int r=n-1;
        int left_most=-1;

        while(l<=r){

            //cal mid
            int mid= l+(r-l)/2;



            if(nums[mid]==target){

                left_most=mid;
                r=mid-1;

            }else if(nums[mid]>target){
                r=mid-1;
            }else{
                l=mid+1;
            }

        }

        return left_most;
    }

    private int findlast(int[] nums,int target , int n){

        int l=0;
        int r=n-1;

        int right_most=-1;

        //bs 

        while(l<=r){

            int mid = l+(r-l)/2;

            if(nums[mid]==target){
                right_most=mid;
                l=mid+1;
            }else if(nums[mid]<target){

                l=mid+1;


            }else{
                r=mid-1;
            }
        }

        return right_most;

    }
}