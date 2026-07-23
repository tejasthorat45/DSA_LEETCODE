public class Solution {

    private string GetCorrect(string s){

        StringBuilder sb = new StringBuilder();

        foreach(char ch in s){

            if(ch=='#'){
                if(sb.Length>0){
                    sb.Length--;
                }
            }else{

                sb.Append(ch);

            }

            
        }

        return sb.ToString();


    }
    public bool BackspaceCompare(string s, string t) {

        return GetCorrect(s)==GetCorrect(t);


        






        
    }
}