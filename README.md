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
**Total: 19** | Easy 5 | Medium 14 | Hard 0

| Pattern | Solved |
|---|---|
| arrays-hashing | 5 |
| two-pointers | 0 |
| sliding-window | 2 |
| stack | 2 |
| binary-search | 0 |
| linked-list | 0 |
| trees | 3 |
| tries | 0 |
| heap-priority-queue | 1 |
| backtracking | 0 |
| graphs | 4 |
| advanced-graphs | 0 |
| dynamic-programming-1d | 0 |
| dynamic-programming-2d | 0 |
| greedy | 1 |
| intervals | 1 |
| math-bit-manipulation | 0 |

| # | Problem | Difficulty | Pattern | Date | Code |
|---|---|---|---|---|---|
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | Easy | arrays-hashing | 2026-10-14 | [code](problems/01-arrays-hashing/0001-two-sum.cs) |
| 49 | [Group Anagrams](https://leetcode.com/problems/group-anagrams/) | Medium | arrays-hashing | 2026-10-15 | [code](problems/01-arrays-hashing/0049-group-anagrams.cs) |
| 242 | [Valid Anagram](https://leetcode.com/problems/valid-anagram/) | Easy | arrays-hashing | 2026-10-18 | [code](problems/01-arrays-hashing/0242-valid-anagram.cs) |
| 347 | [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | Medium | arrays-hashing | 2026-10-16 | [code](problems/01-arrays-hashing/0347-top-k-frequent-elements.cs) |
| 560 | [Subarray Sum Equals K](https://leetcode.com/problems/subarray-sum-equals-k/) | Medium | arrays-hashing | 2026-10-18 | [code](problems/01-arrays-hashing/0560-subarray-sum-equals-k.cs) |
| 3 | [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | Medium | sliding-window | 2026-10-15 | [code](problems/03-sliding-window/0003-longest-substring-without-repeating-characters.cs) |
| 121 | [Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/) | Easy | sliding-window | 2026-10-18 | [code](problems/03-sliding-window/0121-best-time-to-buy-and-sell-stock.cs) |
| 20 | [Valid Parentheses](https://leetcode.com/problems/valid-parentheses/) | Easy | stack | 2026-10-14 | [code](problems/04-stack/0020-valid-parentheses.cs) |
| 739 | [Daily Temperatures](https://leetcode.com/problems/daily-temperatures/) | Medium | stack | 2026-10-18 | [code](problems/04-stack/0739-daily-temperatures.cs) |
| 102 | [Binary Tree Level Order Traversal](https://leetcode.com/problems/binary-tree-level-order-traversal/) | Medium | trees | 2026-10-17 | [code](problems/07-trees/0102-binary-tree-level-order-traversal.cs) |
| 110 | [Balanced Binary Tree](https://leetcode.com/problems/balanced-binary-tree/) | Easy | trees | 2026-10-18 | [code](problems/07-trees/0110-balanced-binary-tree.cs) |
| 236 | [Lowest Common Ancestor of a Binary Tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/) | Medium | trees | 2026-10-17 | [code](problems/07-trees/0236-lowest-common-ancestor-of-a-binary-tree.cs) |
| 973 | [K Closest Points to Origin](https://leetcode.com/problems/k-closest-points-to-origin/) | Medium | heap-priority-queue | 2026-10-16 | [code](problems/09-heap-priority-queue/0973-k-closest-points-to-origin.cs) |
| 200 | [Number of Islands](https://leetcode.com/problems/number-of-islands/) | Medium | graphs | 2026-10-16 | [code](problems/11-graphs/0200-number-of-islands.cs) |
| 207 | [Course Schedule](https://leetcode.com/problems/course-schedule/) | Medium | graphs | 2026-10-17 | [code](problems/11-graphs/0207-course-schedule.cs) |
| 210 | [Course Schedule II](https://leetcode.com/problems/course-schedule-ii/) | Medium | graphs | 2026-10-17 | [code](problems/11-graphs/0210-course-schedule-ii.cs) |
| 994 | [Rotting Oranges](https://leetcode.com/problems/rotting-oranges/) | Medium | graphs | 2026-10-17 | [code](problems/11-graphs/0994-rotting-oranges.cs) |
| 53 | [Maximum Subarray](https://leetcode.com/problems/maximum-subarray/) | Medium | greedy | 2026-10-18 | [code](problems/15-greedy/0053-maximum-subarray.cs) |
| 56 | [Merge Intervals](https://leetcode.com/problems/merge-intervals/) | Medium | intervals | 2026-10-19 | [code](problems/16-intervals/0056-merge-intervals.cs) |
<!-- PROGRESS:END -->
