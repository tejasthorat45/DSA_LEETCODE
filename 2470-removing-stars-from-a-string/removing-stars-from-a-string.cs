public class Solution {
    public string RemoveStars(string s) {


    //     Stack<char> st = new Stack<char>();

    //     foreach(char c in s){

    //         if(c=='*'){
    //             st.Pop();

    //         }else{
    //             st.Push(c);
    //         }

    //     }

    //    char[] arr =  st.ToArray();

    //    Array.Reverse(arr);
    //    return new string(arr);

   char[] arr= s.ToArray();

   int write=0;
   int read =0;

   foreach(char c in arr){

    if(c=='*'){
        write--;
    }else{
        arr[write]=c;
        write++;
    }
   }

   return new string(arr,0,write);

  
    }
}