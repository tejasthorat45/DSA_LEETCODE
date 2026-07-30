public class Solution {
    public int MySqrt(int x) {

        //brtute force 

        //base case

        if(x==0)
        return 0;

        long i=1;
        while(i*i<=x){
            i++;
        }

        return (int)(i-1);


        
    }
}