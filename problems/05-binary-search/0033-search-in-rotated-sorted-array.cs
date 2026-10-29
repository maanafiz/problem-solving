/*
# 33. Search in Rotated Sorted Array
Link: https://leetcode.com/problems/search-in-rotated-sorted-array/
Difficulty: Medium
Date: 2026-10-19
Time: O(log n)  Space: O(log n) for the recursion stack
*/

public class Solution {
    public int Search(int[] nums, int target) {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }

    public int BinarySearch(int[] nums, int target, int left, int right) {
        if (left <= right) {
            int midPoint = left + (right - left)/2;

            if (nums[midPoint] == target) {
                return midPoint;
            }

            if (nums[left] <= nums[midPoint]) { //first half sorted
                if (target >= nums[left] && target < nums[midPoint]) {
                    return BinarySearch(nums, target, left, midPoint - 1);
                } 
                else {
                    return BinarySearch(nums, target, midPoint + 1, right);
                } 
                    
            } else { // second half sorted
                if (target > nums[midPoint] && target <= nums[right]) {
                    return BinarySearch(nums, target, midPoint + 1, right);
                } 
                else {
                    return BinarySearch(nums, target, left, midPoint - 1);
                } 
            }   
        }
        return -1;   
    }
}
