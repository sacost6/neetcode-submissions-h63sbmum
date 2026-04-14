class Solution {
public:
    bool isValid(string s) {
        std::stack<char> stack;
        std::unordered_map<char, char> closeToOpen = {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        
        for(char c: s) {
            // check for a closing char
            if(closeToOpen.contains(c)) {
                // check stack not empty 
                // and top of stack matches the current char's 
                // closing 
                if(!stack.empty() && stack.top() == closeToOpen[c]) {
                    stack.pop();
                }
                else {
                    return false; 
                }
            }
            else {
                // not a closing char, 
                // so place it in the stack 
                stack.push(c);
            }
        }

        return stack.empty(); 
    }

};
