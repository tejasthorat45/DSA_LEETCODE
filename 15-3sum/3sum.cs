public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {

        //OPTIMAL SOLUTION

        //sort the array
        Array.Sort(nums);

        IList<IList<int>> res = new List<IList<int>>();

        for(int i=0;i<nums.Length-2;i++){

            //skip the element 

            if(i>0 && nums[i]==nums[i-1])
             continue;

             //use the 2 ptr approach

             int left =i+1;
             int right=nums.Length-1;

            while(left<right){
                int sum = nums[i]+nums[left]+nums[right];

                if(sum==0){

                    // add this to ther tripllret
                    res.Add(new List<int>{
                        nums[i],nums[left],nums[right]
                    });

                    //move the bothptr 
                    left++;
                    right--;

                    while(left<right && nums[left]==nums[left-1]){
                        left++;
                    }

                    //skip right value
                    while(left<right && nums[right]==nums[right+1])
                    right--;



                }else if(sum>0){
                    right--;

                }else{
                    left++;

                }    
            }    
             
            


        }

        return res;
        
       
    }
}