/*
# 21. Merge Two Sorted Lists
Link: https://leetcode.com/problems/merge-two-sorted-lists/
Difficulty: Easy
Date: 2026-11-01
Time: O(n + m)  Space: O(n + m) for the new nodes it creates
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
        ListNode root = null;
        ListNode lastItem = null;
        while(list1 != null || list2 != null) {
            if (list1 != null && list2 != null) {  
                ListNode itemToAdd = null;
                if(list1.val < list2.val) {
                    itemToAdd = new ListNode(list1.val);
                    if (root == null) {
                        root = itemToAdd;
                        lastItem = itemToAdd;
                    } else {
                        lastItem.next = itemToAdd;
                        lastItem = lastItem.next;     
                    }
                    
                    list1 = list1.next;
                } else {
                    itemToAdd = new ListNode(list2.val);
                    if (root == null) {
                        root = itemToAdd;
                        lastItem = itemToAdd;
                    } else {
                        lastItem.next = itemToAdd;
                        lastItem = lastItem.next;
                    }
                    
                    list2 = list2.next; 
                }
            } else if (list1 == null && list2 != null) {
                if (root == null) {
                    root = list2;
                } else {
                    lastItem.next = list2;
                    lastItem = lastItem.next;     
                }
                break;
            } else if (list1 != null && list2 == null) {
                if (root == null) {
                    root = list1;
                } else {
                    lastItem.next = list1;
                    lastItem = lastItem.next;
                    
                }
                break;
            }
        }
        return root;
    }
}
