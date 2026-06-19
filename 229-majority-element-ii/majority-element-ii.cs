public class Solution {
    public IList<int> MajorityElement(int[] nums) {

        int n= nums.Length;

        int cand1 =0;
        int count1=0;
        int cand2=0;
        int count2=0;

        foreach(int num in nums){

            if(num==cand1)
            count1++;
            else if(num==cand2)
            count2++;
            else if(count1==0){
            cand1=num;
            count1=1;
            }
            else if(count2==0){
                 cand2=num;
                 count2=1;}
            else{
            count1--;
            count2--;
            }


        }

        List<int> res = new();

        count1=0;
        count2=0;

        foreach(int num in nums){
            if(num==cand1)
            count1++;
            else if(num==cand2)
            count2++;
        }

        if(count1>(n/3))
        res.Add(cand1);

        if(count2>(n/3))
        res.Add(cand2);
        

        return res;

        
    }
}