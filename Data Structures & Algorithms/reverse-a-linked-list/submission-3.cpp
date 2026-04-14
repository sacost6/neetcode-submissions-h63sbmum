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
        ListNode* prev = nullptr; 
        ListNode* curr = head; 

        while(curr) {
            // set temp for next
            ListNode * temp = curr->next; 
            // set the next ptr to the previous node
            curr->next = prev; 
            // set the current node as the previous node since it is the new head
            prev = curr; 
            // set the head of the rest of the list as the current node 
            curr = temp; 
        }

        return prev; 
    }
};
