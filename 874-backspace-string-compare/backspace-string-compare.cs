public class Solution {

    // private string GetCorrect(string s){

    //     StringBuilder sb = new StringBuilder();

    //     foreach(char ch in s){

    //         if(ch=='#'){
    //             if(sb.Length>0){
    //                 sb.Length--;
    //             }
    //         }else{

    //             sb.Append(ch);

    //         }

            
    //     }

    //     return sb.ToString();


    // }
    public bool BackspaceCompare(string s, string t) {

        // return GetCorrect(s)==GetCorrect(t);

        int m = s.Length;
        int n = t.Length;

        int i = m-1;
        int j=n-1;

        int skip_s=0;
        int skip_t=0;

        while(i>=0 || j>=0){

            while(i>=0){
                if(s[i]=='#'){

                    skip_s++;
                    i--;

                }else if(skip_s>0){
                    skip_s--;
                    i--;
                }else{
                    break;
                }
            }

            //same for the t

            while(j>=0){
                if(t[j]=='#'){
                    skip_t++;
                    j--;
                }else if(skip_t>0){
                    skip_t--;
                    j--;
                }else{
                    break;
                }
            }

            char first = i<0?'$':s[i];
            char second = j<0 ?'$':t[j];

            if(first!=second)
            return false;

            i--;
            j--;


        }


        return true;


        






        
    }
}