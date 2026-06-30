public class Solution {
    public string ReverseVowels(string s) {


        //brute force using extra space
        List<Char> vowles = new List<Char>();

        foreach(char c in s){

            if(IsVowles(c)){
                vowles.Add(c);
            }
        }

        vowles.Reverse();
        char[] str = s.ToCharArray();

        int idx=0;
        for(int i=0;i<str.Length;i++){
            if(IsVowles(str[i])){
                str[i]=vowles[idx++];
            }
        }

        return new string(str);


        


    }
    bool IsVowles(char c){
        return "aeiouAEIOU".Contains(c);
    }
}