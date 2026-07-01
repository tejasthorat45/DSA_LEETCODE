public class Solution {
    public string ReverseWords(string s) {

        // string[] words = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);

        // Array.Reverse(words);

        // return string.Join(" ",words);

        StringBuilder sb = new StringBuilder();

        int i=s.Length-1;

        while(i>=0){

            //skip spaces

            while(i>=0 && s[i] ==' ')
            i--;

            if(i<0)
            break;

            //mark end of word
            int j=i;
            //move i begining of word

            while(i>=0 && s[i]!=' ')
            i--;
            //append word
            if(sb.Length>0)
            sb.Append(' ');

            sb.Append(s.Substring(i+1,j-i));
        }

        return sb.ToString();




        
    }
}