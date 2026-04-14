public class Solution {
    public int CharacterReplacement(string s, int k) {
        // Check edge cases
        if(s.Length == 0) return 0; 
        
        // Set up a dictionary to count frequencies
        Dictionary<char, int> freq = new Dictionary<char, int>(); 
        int res = 0, l = 0, maxf = 0; 
        // Populate the dictionary
        for(int r = 0; r < s.Length; r++) {
            if(!freq.ContainsKey(s[r])) freq[s[r]] = 0; 

            freq[s[r]]++;
            // get the highest frequency character
            maxf = Math.Max(maxf, freq[s[r]]); 
            
            // iterate while  window size minus max frequency is greater than k 
            while((r - l + 1) - maxf > k) {
                // adjust the count for shrinking window 
                freq[s[l]]--;
                l++;
            }
            res = Math.Max(res, r - l +1); 
        }

        return res; 
    }
}
