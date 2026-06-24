public class Solution {
    public int[] RearrangeArray(int[] nums) {


       // bruite force using 2 list

       List<int> pos = new List<int>();
       List<int> neg = new List<int>();

       foreach(int num in nums){

        if(num>0){
            pos.Add(num);
        }else{
            neg.Add(num);
        }
       }

       //add both

       int p =0;
       int n=0;


       for(int i=0; i<nums.Length; i++){

        if(i%2==0){
            nums[i]=pos[p++];
        }else{
            nums[i]=neg[n++];
        }



       }


      return nums;
        
    }
}