public class Solution {
    public int MajorityElement(int[] nums) {
        int n = nums.Length;

        // //brute force O(n) O(n)
        // Dictionary<int , int > freq = new Dictionary<int,int>();
        

        // foreach(int num in nums){
        //     if(freq.ContainsKey(num)){
        //         freq[num]++;

        //     }else{
        //         freq[num]=1;
        //     }
        // }
        // int maxcount  =0;
        // int maxele=0;

        // foreach(var num in freq){

        //     if(num.Value>maxcount){
        //         maxcount = num.Value;
        //         maxele=num.Key;


        //     }

        // }
        // return maxele;

     //2-->   //using sorting majrtiy ele will always at n/2

        // Array.Sort(nums);
        // return nums[n/2];

     //using Boyer more Voting algo rithm O(n) and O(1)

     int candidate=0;
     int count = 0;

     foreach(int num in nums){

        if(count==0)
        candidate=num;

        if(candidate == num){
            count++;
        }else{
            count--;
        }
     } 

     return candidate;  

                
    }
}