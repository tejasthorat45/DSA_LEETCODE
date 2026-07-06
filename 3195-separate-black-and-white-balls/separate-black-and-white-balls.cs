public class Solution {
    public long MinimumSteps(string s) {

        int n = s.Length;

        int black=0;
        long swap=0;


        for(int i=0;i<n;i++){

            if(s[i]=='0'){ //move this to left

            swap+=black;





            }else{
                black++;
            }


        }

        return swap;


        
        
    }
}