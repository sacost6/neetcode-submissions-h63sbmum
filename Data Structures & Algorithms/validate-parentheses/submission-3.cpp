class Solution {
public:
    bool isValid(string s) {

        // stack 
        std::stack<char> stack; 
        // map the expected opening chars for every closing one
        std::unordered_map<char, char> closeToOpen = {
            { ')','('},
            { '}','{' }, 
            { ']', '['}
        };

        // iterate through each char
        for(char c : s) {
            // check if it is a closing string
            if(closeToOpen.contains(c) ) {
                // check if the stack is not empty and the top has the matching char
                if(!stack.empty() && stack.top() == closeToOpen[c]) {
                    stack.pop(); 
                }
                else {
                    return false; 
                }
            }
            else {
                stack.push(c);
            }
        }

        return stack.empty();
    }
};
