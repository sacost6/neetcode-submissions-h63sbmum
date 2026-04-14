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
    ListNode* mergeTwoLists(ListNode* list1, ListNode* list2) {
        // recursive

        // check if either list is empty
        if(list1 == nullptr) {
            return list2; 
        }

        if(list2 == nullptr) {
            return list1; 
        }

        // check if the value of list 1 is greater than or equal to the value in list2
        if(list1->val <= list2->val) {
            // move the value in list 1
            list1->next = mergeTwoLists(list1->next, list2);
            return list1;  
        }
        else {
            // move value in list 2
            list2->next = mergeTwoLists(list1, list2->next);
            return list2; 
        }
    }
};
