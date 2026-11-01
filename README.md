# Problem Solving

My data structures and algorithms practice in C#, mostly LeetCode. Problems are grouped by pattern,
and each solution records its difficulty and time/space complexity.

## Structure

```
problems/<pattern>/NNNN-slug.cs   one file per problem: header + solution
templates/Solution.cs             starting file used by scripts/new.cs
scripts/                          new.cs (create a problem), stats.cs (refresh progress)
```

## Workflow

The scripts need the .NET 10 SDK (runs single .cs files directly, no project needed).

```bash
dotnet run scripts/new.cs 49 group-anagrams arrays medium      # create the file
dotnet run scripts/stats.cs                                    # refresh the table below
```

## Progress

<!-- PROGRESS:START -->
**Total: 30** | Easy 10 | Medium 20 | Hard 0

| Pattern | Solved |
|---|---|
| arrays-hashing | 5 |
| two-pointers | 2 |
| sliding-window | 2 |
| stack | 3 |
| binary-search | 1 |
| linked-list | 0 |
| trees | 3 |
| tries | 0 |
| heap-priority-queue | 1 |
| backtracking | 0 |
| graphs | 4 |
| advanced-graphs | 0 |
| dynamic-programming-1d | 3 |
| dynamic-programming-2d | 0 |
| greedy | 3 |
| intervals | 1 |
| math-bit-manipulation | 2 |

| # | Problem | Difficulty | Pattern | Date | Code |
|---|---|---|---|---|---|
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | Easy | arrays-hashing | 2026-10-14 | [code](problems/01-arrays-hashing/0001-two-sum.cs) |
| 49 | [Group Anagrams](https://leetcode.com/problems/group-anagrams/) | Medium | arrays-hashing | 2026-10-15 | [code](problems/01-arrays-hashing/0049-group-anagrams.cs) |
| 242 | [Valid Anagram](https://leetcode.com/problems/valid-anagram/) | Easy | arrays-hashing | 2026-10-18 | [code](problems/01-arrays-hashing/0242-valid-anagram.cs) |
| 347 | [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | Medium | arrays-hashing | 2026-10-16 | [code](problems/01-arrays-hashing/0347-top-k-frequent-elements.cs) |
| 560 | [Subarray Sum Equals K](https://leetcode.com/problems/subarray-sum-equals-k/) | Medium | arrays-hashing | 2026-10-18 | [code](problems/01-arrays-hashing/0560-subarray-sum-equals-k.cs) |
| 15 | [3Sum](https://leetcode.com/problems/3sum/) | Medium | two-pointers | 2026-10-29 | [code](problems/02-two-pointers/0015-3sum.java) |
| 125 | [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/) | Easy | two-pointers | 2026-10-29 | [code](problems/02-two-pointers/0125-valid-palindrome.java) |
| 3 | [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | Medium | sliding-window | 2026-10-15 | [code](problems/03-sliding-window/0003-longest-substring-without-repeating-characters.cs) |
| 121 | [Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/) | Easy | sliding-window | 2026-10-18 | [code](problems/03-sliding-window/0121-best-time-to-buy-and-sell-stock.cs) |
| 20 | [Valid Parentheses](https://leetcode.com/problems/valid-parentheses/) | Easy | stack | 2026-10-14 | [code](problems/04-stack/0020-valid-parentheses.cs) |
| 232 | [Implement Queue using Stacks](https://leetcode.com/problems/implement-queue-using-stacks/) | Easy | stack | 2026-10-19 | [code](problems/04-stack/0232-implement-queue-using-stacks.cs) |
| 739 | [Daily Temperatures](https://leetcode.com/problems/daily-temperatures/) | Medium | stack | 2026-10-18 | [code](problems/04-stack/0739-daily-temperatures.cs) |
| 33 | [Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/) | Medium | binary-search | 2026-10-19 | [code](problems/05-binary-search/0033-search-in-rotated-sorted-array.cs) |
| 102 | [Binary Tree Level Order Traversal](https://leetcode.com/problems/binary-tree-level-order-traversal/) | Medium | trees | 2026-10-17 | [code](problems/07-trees/0102-binary-tree-level-order-traversal.cs) |
| 110 | [Balanced Binary Tree](https://leetcode.com/problems/balanced-binary-tree/) | Easy | trees | 2026-10-18 | [code](problems/07-trees/0110-balanced-binary-tree.cs) |
| 236 | [Lowest Common Ancestor of a Binary Tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/) | Medium | trees | 2026-10-17 | [code](problems/07-trees/0236-lowest-common-ancestor-of-a-binary-tree.cs) |
| 973 | [K Closest Points to Origin](https://leetcode.com/problems/k-closest-points-to-origin/) | Medium | heap-priority-queue | 2026-10-16 | [code](problems/09-heap-priority-queue/0973-k-closest-points-to-origin.cs) |
| 200 | [Number of Islands](https://leetcode.com/problems/number-of-islands/) | Medium | graphs | 2026-10-16 | [code](problems/11-graphs/0200-number-of-islands.cs) |
| 207 | [Course Schedule](https://leetcode.com/problems/course-schedule/) | Medium | graphs | 2026-10-17 | [code](problems/11-graphs/0207-course-schedule.cs) |
| 210 | [Course Schedule II](https://leetcode.com/problems/course-schedule-ii/) | Medium | graphs | 2026-10-17 | [code](problems/11-graphs/0210-course-schedule-ii.cs) |
| 994 | [Rotting Oranges](https://leetcode.com/problems/rotting-oranges/) | Medium | graphs | 2026-10-17 | [code](problems/11-graphs/0994-rotting-oranges.cs) |
| 91 | [Decode Ways](https://leetcode.com/problems/decode-ways/) | Medium | dynamic-programming-1d | 2026-10-29 | [code](problems/13-dynamic-programming-1d/0091-decode-ways.java) |
| 322 | [Coin Change](https://leetcode.com/problems/coin-change/) | Medium | dynamic-programming-1d | 2026-10-28 | [code](problems/13-dynamic-programming-1d/0322-coin-change.java) |
| 746 | [Min Cost Climbing Stairs](https://leetcode.com/problems/min-cost-climbing-stairs/) | Easy | dynamic-programming-1d | 2026-10-19 | [code](problems/13-dynamic-programming-1d/0746-min-cost-climbing-stairs.cs) |
| 53 | [Maximum Subarray](https://leetcode.com/problems/maximum-subarray/) | Medium | greedy | 2026-10-18 | [code](problems/15-greedy/0053-maximum-subarray.cs) |
| 55 | [Jump Game](https://leetcode.com/problems/jump-game/) | Medium | greedy | 2026-10-31 | [code](problems/15-greedy/0055-jump-game.java) |
| 2938 | [Separate Black and White Balls](https://leetcode.com/problems/separate-black-and-white-balls/) | Medium | greedy | 2026-10-19 | [code](problems/15-greedy/2938-separate-black-and-white-balls.cs) |
| 56 | [Merge Intervals](https://leetcode.com/problems/merge-intervals/) | Medium | intervals | 2026-10-19 | [code](problems/16-intervals/0056-merge-intervals.cs) |
| 190 | [Reverse Bits](https://leetcode.com/problems/reverse-bits/) | Easy | math-bit-manipulation | 2026-10-30 | [code](problems/17-math-bit-manipulation/0190-reverse-bits.java) |
| 191 | [Number of 1 Bits](https://leetcode.com/problems/number-of-1-bits/) | Easy | math-bit-manipulation | 2026-10-30 | [code](problems/17-math-bit-manipulation/0191-number-of-1-bits.java) |
<!-- PROGRESS:END -->
