class Solution {
public:
    bool isAnagram(string s, string t) {
        // check string length 
        if(s.length() != t.length()){
            return false; 
        }

        // create a hashmap 
        unordered_map<char, int> sMap, tMap; 
        // iterate through the string, we know the lengths are the same 

        for(int i = 0; i < s.length(); i++) {
            // increment
            sMap[s[i]]++;
            tMap[t[i]]++;
        }

        return sMap == tMap;
    }
};
