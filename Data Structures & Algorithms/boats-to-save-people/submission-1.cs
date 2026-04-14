public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        // Sort
        Array.Sort(people); 
        int n = people.Length; 
        List<List<int>> res = new List<List<int>>(); 

        // Set the two pointers
        int l = 0, r = n-1; 
        while(l <= r) {
            int weight = people[l] + people[r]; 
            if(weight > limit) {
                List<int> temp = new List<int>(); 
                temp.Add(people[r]);
                res.Add(temp);
                r--; 
            }
            else {
                List<int> temp = new List<int>(); 
                temp.Add(people[l]); 
                temp.Add(people[r]);
                l++;
                r--;
                res.Add(temp);
            }
        }
        return res.Count(); 
    }
}