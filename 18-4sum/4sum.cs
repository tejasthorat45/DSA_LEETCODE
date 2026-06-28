public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {

        //optimak

        Array.Sort(nums);
        int n=nums.Length;

        //to store the res 
        IList<IList<int>> res = new List<IList<int>>();

        for(int i=0;i<n-3;i++){


            //skip i duplicate 
            if(i>0 && nums[i]==nums[i-1])
            continue;

            for(int j=i+1;j<n-2;j++){

                //skip the duplicate which occurs at the j

                if(j>i+1 && nums[j]==nums[j-1])
                continue;

                //start the 2 ptr approch 
                int l = j+1;
                int r = n-1;

                while(l<r){

                    long sum = (long)nums[i]+nums[j]+nums[l]+nums[r];

                    if(sum==target){

                        res.Add(new List<int>{
                            nums[i],
                            nums[j],
                            nums[l],
                            nums[r]
                        });

                        //skip the duplo

                        while(l<r && nums[l]==nums[l+1])
                        l++;

                        //same goes for the r

                        while(l<r && nums[r]==nums[r-1])
                        r--;

                        l++;
                        r--;




                    }else if(sum<target){
                        l++;

                    }else{
                        r--;

                    }
                }
            }
        }

        return res;
        
    }
}