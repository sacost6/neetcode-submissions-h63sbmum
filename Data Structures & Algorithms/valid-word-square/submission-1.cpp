class Solution {
public:
    bool validWordSquare(vector<string>& words) {
        // Check empty 
        if(words.size() == 0) {
            return false; 
        }
        
        for(int i=0; i < words.size(); i++) {
            for(int j=0; j < words[i].size(); j++) {
                if(i == j) { 
                    continue; 
                }

                // To safely access the 'mirror' character words[j][i]:
                if (j >= words.size() || i >= words[j].size()) {
                    return false; // Mirror character doesn't exist
                }

                if(words[i][j] != words[j][i]) {
                    return false; 
                }
            }
        }

        return true; 

    }
};
