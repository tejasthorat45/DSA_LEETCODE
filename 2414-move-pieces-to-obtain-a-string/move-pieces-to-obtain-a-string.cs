public class Solution {
    public bool CanChange(string start, string target) {


        int i=0;
        int j=0;
        int n = start.Length;

        while(i<n || j<n){

            while(i<n && start[i]=='_')
            i++;

            while(j<n && target[j]=='_')
            j++;

            if(i==n || j==n){
                return i==n && j==n;
            }

            //check l and r

            if(start[i]!=target[j])
            {
                return false;
            }

            if(start[i]=='L' && i<j)
            return false;

            if(start[i]=='R' && i>j)
            return false;

            i++;
            j++;
        }

        return true;
        
    }
}