/*

2️⃣ Subarray With Given Sum

Question:
Given an integer array and a target sum, find if a continuous subarray exists whose sum equals the target.

Example:
Input: {1, 4, 20, 3, 10, 5}, target = 33
Output: true (20 + 3 + 10)

3️⃣ Longest Increasing Subsequence (Simplified)

Question:
Find the length of the longest increasing subsequence in an array.

Example:
Input: {10, 9, 2, 5, 3, 7, 101}
Output: 4 (2, 3, 7, 101)

🟩 Lists (Intermediate)
4️⃣ Sliding Window Maximum

Question:
Given a list of integers and a window size k, find the maximum value in each window.

Example:
Input: {1, 3, -1, -3, 5, 3, 6, 7}, k = 3
Output: {3, 3, 5, 5, 6, 7}

5️⃣ Rearrange Positives and Negatives

Question:
Rearrange a list so that positive and negative numbers alternate, maintaining relative order as much as possible.

Example:
Input: {1, -2, 3, -4, -1, 4}
Output: {1, -2, 3, -4, 4, -1}

6️⃣ Detect Loop Using Hashing

Question:
Given a list of integers, determine if there is a cycle (repeating traversal) using a dictionary or hash set.

🟨 Dictionaries (Intermediate)
7️⃣ Two Sum Using Dictionary

Question:
Given an array and a target value, return indices of the two numbers that add up to the target.

Example:
Input: {2, 7, 11, 15}, target = 9
Output: {0, 1}

8️⃣ Top K Frequent Elements

Question:
Given an array of integers, find the top k most frequent elements.

Example:
Input: {1,1,1,2,2,3}, k = 2
Output: {1, 2}

9️⃣ Anagram Grouping

Question:
Group strings that are anagrams using a dictionary.

Example:
Input: {"eat","tea","tan","ate","nat","bat"}
Output:
{"eat","tea","ate"}
{"tan","nat"}
{"bat"}

🔥 HARD MODE (Borderline Advanced)
🔟 Longest Consecutive Sequence

Question:
Find the length of the longest consecutive elements sequence.

Example:
Input: {100, 4, 200, 1, 3, 2}
Output: 4 (1, 2, 3, 4)

⚠️ Must run in O(n) time.

🔥 11️⃣ Subarray Sum Equals K

Question:
Count the total number of subarrays whose sum equals k.

🔥 12️⃣ Dictionary + Prefix Logic

Question:
Implement a basic prefix search (like auto-complete) using a dictionary.

Example:
Words: {"cat","car","cart","dog"}
Input: "ca"
Output: {"cat","car","cart"}*/
using System.Diagnostics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

class Practice
{
    /*
    🟥 Arrays (Intermediate)
1️⃣ Rotate Array by K Positions

Question:
Given an array, rotate it to the right by k steps.

Example:
Input: {1, 2, 3, 4, 5}, k = 2
Output: {4, 5, 1, 2, 3}

⚠️ Constraint: Do it in O(n) time.

    */
    static void Main(string[] args)
    {
        int[] arr = [1, 2, 3, 4, 5];
        int steps = 2;
        for (int i = 0; i < arr.Length; i++)
        {
            if (steps > 0)
            {
                steps--;
            }
            for (int j = i + 1; j < arr.Length - i; i++)
            {

            }


        }


    }

}