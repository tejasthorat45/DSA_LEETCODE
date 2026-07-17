public class Solution {
    public bool IsSubsequence(string s, string t) {

        // //brute force approach


        // int start =0;
        // foreach(char c in s ){
        //     bool found = false;

        //     while(start<t.Length){

                

        //         if(t[start]==c){
        //             found =true;
        //             start++;

        //             break;

        //         }
        //         start++;

        //     }

        //       if(!found)
        //        return false;
        // }

      

        // return true;

        //using two pointer 

        int i=0;
        int j=0;

        while(i<s.Length && j<t.Length){

            if(s[i]==t[j]){
                i++;
                
            }

            j++;
        }

        if(i==s.Length)
        return true;

        return false;


        
    }
}