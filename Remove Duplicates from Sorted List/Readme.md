Remove Duplicates from Sorted List

Problem Description
Given the `head` of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

Solution Approach
Since the linked list is sorted, any duplicate nodes will be adjacent to each other. We can traverse the list in a single pass to remove them.
1. First, we check if the list is empty (`head == null`). If so, we return `null`.
2. We initialize a `current` pointer starting at the `head` of the list.
3. We loop through the list as long as there is a next node to compare (`current.next != null`).
4. Inside the loop, we check if the current node's value equals the next node's value (`current.val == current.next.val`).
5. If they are equal, we have found a duplicate. We bypass the duplicate node by updating our current node's `next` pointer to point to the node after the duplicate (`current.next = current.next.next`). We do not move the `current` pointer forward yet, because the new `next` node might also be a duplicate.
6. If the values are different, we simply move the `current` pointer forward to the next node (`current = current.next`).
7. Once the loop finishes, we return the modified original `head` of the list.
8. The time complexity is $O(n)$ as we visit each node exactly once. Space complexity is $O(1)$ since we are modifying the list in-place.

Technologies Used
- C# (Linked List Traversal, In-place Pointer Manipulation)
