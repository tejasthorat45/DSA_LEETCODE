/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {

        // for(int i=1;i<=n;i++){
        //     int res = guess(i);


        //     if(res==0){
        //         return i;
        //     }
        // }

        //using the BS

        int l=1;
        int r=n;

        while(l<=r){


            int mid = l+(r-l)/2;

            if(guess(mid)==0){
                return mid;
            }else if(guess(mid)==-1){
                r=mid-1;
            }else{
                l=mid+1;
            }
        }

        return -1;
        
    }
}