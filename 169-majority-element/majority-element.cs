public class Solution {
    public int MajorityElement(int[] nums) {

        Dictionary<int , int > freq = new Dictionary<int,int>();
        int n = nums.Length;

        foreach(int num in nums){
            if(freq.ContainsKey(num)){
                freq[num]++;

            }else{
                freq[num]=1;
            }
        }
        int maxcount  =0;
        int maxele=0;

        foreach(var num in freq){

            if(num.Value>maxcount){
                maxcount = num.Value;
                maxele=num.Key;


            }

        }
        return maxele;
        
    }
}