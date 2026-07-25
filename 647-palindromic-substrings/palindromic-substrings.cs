public class Solution {

    //to check the Plaidrom sub

    private bool IsPalindrome(string s, int start, int end){
      while(start<end){
        if(s[start]!=s[end]){
            return false;
        }

        start++;
        end--;
      }

      return true;
    }
    public int CountSubstrings(string s) {

        int count =0;

        for(int start=0;start<s.Length;start++){

            for(int end = start;end<s.Length;end++){

                if(IsPalindrome(s,start,end)){
                    count++;
                }
            }
        }

        return count;
        
        
    }
}