/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */

class Solution {
public:
    ListNode* reverseList(ListNode* head) {
        // Check for the empty list
        if(!head) {
            return nullptr; 
        }

        // create the new head that will be pointed to 
        // temporarily set it to the current head
        ListNode* newHead = head; 

        // check if this is the last node
        if(head->next) {
            // not the last node, recusrively call 
            newHead = reverseList(head->next);
            // swapping line, set next node's next to current node
            head->next->next = head; 
        }
        // the  head should now point to null since its the last node
        // otherwise creates a looping condition 
        head->next = nullptr; 
        return newHead; 
    }
};
