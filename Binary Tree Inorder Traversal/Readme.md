Binary Tree Inorder Traversal

Problem Description
Given the `root` of a binary tree, return the inorder traversal of its nodes' values. In an inorder traversal, the nodes are visited in the following order: Left child, Root node, Right child.

Solution Approach
The most elegant and standard way to solve tree traversal problems is using **Recursion** (Depth-First Search).
1. We create a main function that initializes an empty list, `result`, to hold our final output.
2. We create a helper function, `Traverse`, which takes the current `node` and the `result` list as parameters.
3. **Base Case:** Inside the helper function, if the current node is `null`, we simply `return` and do nothing. This prevents errors when we reach the end of a branch.
4. **Recursive Steps (Inorder):**
   - **Left:** We recursively call `Traverse(node.left, result)` to explore the entire left subtree first.
   - **Root:** Once the left side returns, we process the current node by adding its value (`node.val`) to our `result` list.
   - **Right:** Finally, we recursively call `Traverse(node.right, result)` to explore the right subtree.
5. The recursive stack naturally unwinds, ensuring the elements are added strictly in Left -> Root -> Right order. The time complexity is $O(n)$ as we visit each node exactly once. Space complexity is $O(n)$ in the worst case due to the recursion stack.

Technologies Used
- C# (Binary Tree, Depth-First Search, Recursion)
