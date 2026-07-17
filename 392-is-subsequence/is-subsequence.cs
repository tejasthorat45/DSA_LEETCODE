public class Solution {
    public bool IsSubsequence(string s, string t) {

        //brute force approach


        int start =0;
        foreach(char c in s ){
            bool found = false;

            while(start<t.Length){

                

                if(t[start]==c){
                    found =true;
                    start++;

                    break;

                }
                start++;

            }

              if(!found)
               return false;
        }

      

        return true;
        
    }
}