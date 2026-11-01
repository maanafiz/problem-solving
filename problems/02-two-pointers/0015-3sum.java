/*
# 15. 3Sum
Link: https://leetcode.com/problems/3sum/
Difficulty: Medium
Date: 2026-10-29
Time: O(n^2)  Space: O(1) extra, apart from sorting and the output
*/

class Solution {
    public List<List<Integer>> threeSum(int[] nums) {
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        Arrays.sort(nums);
        for(int i = 0; i < nums.length; i++) {
            if (i > 0 && nums[i - 1] == nums[i]) {
                continue;
            }
            int target = nums[i] * -1;
            int j = i + 1;
            int k = nums.length - 1;
            while(j < k) {
                if (i == j) {
                    j++;
                    continue;
                }
                if (i == k) {
                    k--;
                    continue;
                }
                int currentSum = nums[j] + nums[k];
                if (currentSum > target) {
                    k--;
                } else if (currentSum < target) {
                    j++;
                } else {
                    result.add(Arrays.asList(nums[i], nums[j], nums[k]));
                    int left = nums[j];
                    while(nums[j] == left && j < k) {
                        j++;
                    }

                    int right = nums[k];
                    while(nums[k] == right && j < k) {
                        k--;
                    }
                }
            }
        }
        return result;
    }
}
