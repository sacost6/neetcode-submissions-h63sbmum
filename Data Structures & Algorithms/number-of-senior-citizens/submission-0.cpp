class Solution {
public:
    int countSeniors(vector<string>& details) {
        int counter = 0; 

        for(string s : details) {
            int age = stoi(s.substr(11, 2));
            if(age > 60) {
                counter++;
            }
        }

        return counter; 
    }
};