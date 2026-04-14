class MinStack {
private:
    std::stack<int> tStack;
    std::stack<int> minStack;

public: 
    MinStack() {}
    
    void push(int val) {
        tStack.push(val);
        val = std::min(val, minStack.empty() ? val : minStack.top());
        if(!minStack.empty() && val > minStack.top()) {
            minStack.push(val);
        }
        else {
            minStack.push(val);
        } 
    }
    
    void pop() {
        minStack.pop(); 
        tStack.pop(); 
    }
    
    int top() {
        return tStack.top(); 
    }
    
    int getMin() {
        return minStack.top(); 
    }
};
