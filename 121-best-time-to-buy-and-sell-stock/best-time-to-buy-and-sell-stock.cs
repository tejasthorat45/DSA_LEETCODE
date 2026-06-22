public class Solution {
    public int MaxProfit(int[] prices) {

        ///using the bruite force 

        int n=prices.Length;

        // int maxprofit =0;

        // for(int i=0;i<n;i++){




        //     for(int j=i+1;j<n;j++){
        //         int currentpf=0;
        //         currentpf=prices[j]-prices[i];

        //         maxprofit=Math.Max(maxprofit,currentpf);



        //     }
        // }

        // return maxprofit;

        //using one pass solution 
        int min=prices[0];
        int maxprofit = 0;

        foreach(int num in prices){

            //find the profit 
            maxprofit= Math.Max(maxprofit,num-min);

            //find min
            min = Math.Min(min,num);

        }

        return maxprofit;
        
    }
}