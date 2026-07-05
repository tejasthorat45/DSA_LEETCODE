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
        


        // //using the HASHSET  O(n*m)  O(k) SC

        // HashSet<int> temp = new HashSet<int>(nums1);
        // HashSet<int> res = new HashSet<int>();

        // foreach(int num in nums2 ){

        //     if(temp.Contains(num)){
        //         res.Add(num);

        //     }
        // }

        // return res.ToArray();

        //using sorting and Two ptr

        Array.Sort(nums1);
        Array.Sort(nums2);


        List<int> res = new List<int>();

        int i=0;
        int j=0;


        while(i<nums1.Length && j<nums2.Length){



            if(nums1[i]==nums2[j]){

                //ADDD TO RES
                //CHECK IF THERE IS DUPLICATE

                if(res.Count==0 || res[res.Count-1]!=nums1[i]){
                    res.Add(nums1[i]);
                }
                i++;
                j++;
            }else if(nums1[i]>nums2[j]){
                j++;
            }else{
                i++;
            }
        }

        return res.ToArray();




    }
}