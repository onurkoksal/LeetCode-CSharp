Merge Two Sorted Lists

Problem Description
Given the heads of two sorted linked lists,
`list1` and `list2`, merge the two lists into a single sorted linked list. 
The new list should be constructed by splicing together the nodes of the first two lists. 
Return the head of the merged linked list.

Solution Approach
This problem is solved optimally in $O(n + m)$ time complexity using a **Two-Pointer** approach with a dummy node.
1. A `dummy` node is initialized to act as the starting point of the merged list, simplifying edge cases.
2. A `current` pointer tracks the end of the newly merged list.
3. We iterate through both lists simultaneously. At each step, we compare the values of the current nodes from `list1` and `list2`. The node with the smaller value is appended to the `current.next`, and that specific list's pointer is advanced.
4. If one of the lists is exhausted before the other, the remaining portion of the non-empty list is directly appended to the merged list, as it is already sorted.
5. The merged list begins at `dummy.next`.

Technologies Used
- C# (Linked Lists, Pointers)
