public class Solution {

  
    public void SortColors(int[] nums) {
       // Array.Sort(nums); // O(nlogn)

    //    //using the o(n)
    //    int count0 =0;
    //    int count1=0;
    //    int count2 =0;

    //    foreach(int i in nums){
    //     if(i == 0)count0++;
    //     else if(i==1)count1++;
    //     else count2++;
    //    }
    //    int idx=0;
    //    while(count0-- >0)
    //    nums[idx++]=0;

    //    while(count1-- >0)
    //    nums[idx++]=1;

       
    //    while(count2-- > 0)
    //    nums[idx++]=2;

    //using the duch nNational flag algo rithm
    //using threee pointer 
    int n= nums.Length;

    int high =n-1;
    int low =0;
    int mid=0;

    while(mid<=high){
        if(nums[mid]==0){
            (nums[low],nums[mid])=(nums[mid],nums[low]);
            low++;
            mid++;
           
        }else if(nums[mid]==1){
            mid++;
            
        }else{
             (nums[mid],nums[high])=(nums[high],nums[mid]);
            high--;
            
        }
      
    }


       
        
    }
}