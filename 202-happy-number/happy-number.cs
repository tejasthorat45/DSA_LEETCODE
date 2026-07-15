public class Solution {
    public bool IsHappy(int n) {

        // for(int i=0;i<1000;i++){
        //     if(n==1)
        //     return true;

        //     n=nextNo(n);


        // }

        // return false;

        //using the hashset

        HashSet<int> visited = new HashSet<int>();

        while(n!=1){

            if(visited.Contains(n))
            return false;

            visited.Add(n);

            n=nextNo(n);
        }

        return true;

        
    }

    private int nextNo(int n){
        int sum =0;
        while(n>0){
            int digit=n%10;
            sum+=digit*digit;
            n/=10;
        }

        return sum;
    }
}