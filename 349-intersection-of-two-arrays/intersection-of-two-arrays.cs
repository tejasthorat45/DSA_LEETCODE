public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {

        // List<int> ans = new List<int>();
      



        // foreach(int num in nums1){

        //     foreach(int nam in nums2){

        //         if(num==nam && !ans.Contains(num)){

        //             ans.Add(num);

        //         }
        //     }
        // }

        // return ans.ToArray();
        


        //using the HASHSET

        HashSet<int> temp = new HashSet<int>(nums1);
        HashSet<int> res = new HashSet<int>();

        foreach(int num in nums2 ){

            if(temp.Contains(num)){
                res.Add(num);

            }
        }

        return res.ToArray();


    }
}