public class Solution {
    public int Compress(char[] chars) {

        int n = chars.Length;
        int write=0;
        int read=0;



        while(read<n){

            int count =0;
            char current = chars[read];

            while(read<n && chars[read]==current){

                count++;
                read++;
            }

            chars[write++]=current;

            if(count>1){

                foreach(char c in count.ToString()){
                    chars[write++]=c;
                }
            }
        }

        return write;

        



        
    }
}