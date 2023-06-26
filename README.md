# Data Structures Implementation in C#

This project showcases my implementation of various data structures in C#. I have implemented the following data structures from scratch:

- **Binary Tree**: A binary tree data structure with support for insertion, deletion, and traversal operations.
- **Dictionary**: A dictionary data structure that stores key-value pairs and provides efficient lookup and retrieval operations.
- **Heap**: A heap data structure that maintains a partially ordered binary tree and supports efficient insertion and extraction of the minimum (or maximum) element.
- **Linked List**: A linked list data structure with support for adding, removing, and traversing elements. This implementation includes both a generic version and a non-generic version.
- **List (Dynamic Array)**: A dynamic array implementation that allows resizing and efficient random access to elements.
- **Queue**: A queue data structure that follows the first-in-first-out (FIFO) principle, with enqueue and dequeue operations.
- **Queue (Generic)**: A generic version of the queue data structure that allows storing elements of any type.
- **Stack**: A stack data structure that follows the last-in-first-out (LIFO) principle, with push and pop operations.
- **Stack (Generic)**: A generic version of the stack data structure that allows storing elements of any type.

Each data structure is implemented with proper encapsulation, error handling, and adherence to best practices. The code is written in C# and follows object-oriented principles to ensure modularity and reusability.

## Unit Tests

Unit tests have been implemented for each data structure to verify their functionality and ensure that they work correctly in different scenarios. The unit tests are located in the `TestStructureData` directory and cover various aspects of the data structure operations.

---

# List (Dynamic Array)

## Description
A List is a dynamic array-based data structure that stores a collection of elements. It provides dynamic resizing and supports various operations such as adding, removing, searching, sorting, and more.

## Methods
- `Add(T? value)`: Adds a value to the list.
- `Clear()`: Removes all elements from the list.
- `Print()`: Prints the elements of the list.
- `IndexOf(T value)`: Returns the index of the first occurrence of the specified value in the list.
- `Insert(int index, T value)`: Inserts a value at the specified index in the list.
- `Remove(T value)`: Removes the first occurrence of the specified value from the list.
- `RemoveAt(int index)`: Removes the element at the specified index from the list.
- `Sort()`: Sorts the elements in the list in ascending order.
- `Reverse()`: Reverses the order of the elements in the list.
- `this[int index]`: Indexer that allows accessing and modifying elements in the list by index.

## Time Complexities
- `Add`: O(1) amortized (O(n) when resizing the underlying array)
- `Clear`: O(1)
- `Print`: O(n)
- `IndexOf`: O(n)
- `Insert`: O(n)
- `Remove`: O(n)
- `RemoveAt`: O(n)
- `Sort`: O(n log n)
- `Reverse`: O(n)

## Explanation
The `ListDynamicArray` class is implemented using a dynamic array, where the underlying array is resized as needed to accommodate the elements.

- The `Add` method adds a value to the list by appending it to the end of the array. If the array is full, it is resized using the `ResizeList` method, which doubles the capacity of the array. The time complexity of adding an element is O(1) on average (amortized), but O(n) in the worst case when resizing the array.

- The `Clear` method sets all elements in the array to default values, effectively removing all elements from the list. It runs in constant time O(1).

- The `Print` method iterates over the elements in the array and prints them. It has a time complexity of O(n), where n is the number of elements in the list.

- The `IndexOf` method searches for the first occurrence of a specified value in the list by iterating over the elements in the array. If the value is found, the corresponding index is returned. Otherwise, an exception is thrown. The time complexity of this method is O(n), where n is the number of elements in the list.

- The `Insert` method inserts a value at the specified index in the list by shifting elements to the right to make room for the new element. If the array is full, it is resized before inserting the value. The time complexity of inserting an element is O(n), as shifting elements requires updating their positions.

- The `Remove` method removes the first occurrence of a specified value from the list by shifting elements to the left to fill the gap. It has a time complexity of O(n) in the worst case, as shifting elements requires updating their positions.

- The `RemoveAt` method removes the element at the specified index from the list by shifting elements to the left to fill the gap. It also has a time complexity of O(n) in the worst case.

- The `Sort` method uses the QuickSort algorithm to sort the elements in the list in ascending order. It has a time complexity of O(n log n).

- The `Reverse` method reverses the order of the elements in the list by swapping elements from the beginning and end of the array. It runs in linear time O(n), where n is the number of elements in the list.

- The `this[int index]` indexer allows accessing and modifying elements in the list by index. It provides read and write access to the elements and throws an exception if an invalid index is used.

The List implemented with a Dynamic Array provides efficient random access and supports various operations commonly used in data manipulation and processing scenarios. It is suitable for situations where the size of the collection changes dynamically, and frequent insertion and removal operations are required.

***

# LinkedList

Description: A LinkedList is a data structure where each element (node) contains a reference to the next node in the sequence.

## Methods

- `AddFirst(T value)`: Adds an element to the beginning of the linked list.
- `AddLast(T value)`: Adds an element to the end of the linked list.
- `RemoveFirst()`: Removes the first element from the linked list.
- `RemoveLast()`: Removes the last element from the linked list.
- `AddAfter(T movableValue, T value)`: Adds an element after a specific value in the linked list.
- `AddBefore(T movableValue, T value)`: Adds an element before a specific value in the linked list.
- `Count()`: Returns the number of elements in the linked list.

## Time Complexities

- `AddFirst`: O(1)
- `AddLast`: O(1)
- `RemoveFirst`: O(1)
- `RemoveLast`: O(n)
- `AddAfter`: O(n)
- `AddBefore`: O(n)
- `Count`: O(1)

***

# Stack

Description: A Stack is a linear data structure that follows the Last-In-First-Out (LIFO) principle. Elements are added and removed from the top of the stack.

## Methods

- `Push(T value)`: Adds an element to the top of the stack.
- `Pop()`: Removes and returns the element from the top of the stack.
- `Peek()`: Returns the element at the top of the stack without removing it.
- `Clear()`: Clears all elements from the stack.
- `Contains(T value)`: Checks if the stack contains a specific value.

## Time Complexities

- `Push`: O(1)
- `Pop`: O(1)
- `Peek`: O(1)
- `Clear`: O(1)
- `Contains`: O(n)

***

# Queue

Description: A Queue is a linear data structure that follows the First-In-First-Out (FIFO) principle. Elements are added at the rear (enqueue) and removed from the front (dequeue).

## Methods

- `Enqueue(T value)`: Adds an element to the rear of the queue.
- `Dequeue()`: Removes and returns the element from the front of the queue.
- `Peek()`: Returns the element at the front of the queue without removing it.
- `Clear()`: Clears all elements from the queue.
- `Contains(T value)`: Checks if the queue contains a specific value.

## Time Complexities

- `Enqueue`: O(1)
- `Dequeue`: O(1)
- `Peek`: O(1)
- `Clear`: O(1)
- `Contains`: O(n)

***

# Binary Tree

Description: A Binary Tree is a hierarchical data structure composed of nodes, where each node has at most two children, referred to as the left child and the right child. The Binary Tree class represents a node in the tree and provides methods for adding, searching, and removing nodes in the tree.

## Class: BinaryTree

### Properties

- `private BinaryTree? _parent`: Reference to the parent node.
- `private BinaryTree? _left`: Reference to the left child node.
- `private BinaryTree? _right`: Reference to the right child node.
- `private int _value`: Value stored in the current node.

### Methods

- `public BinaryTree(int value, BinaryTree? parent)`: Constructs a new instance of the BinaryTree class with the specified value and parent node.
- `public void Add(int value)`: Adds a new node with the specified value to the binary tree.
- `private BinaryTree? Search(BinaryTree? tree, int value)`: Recursively searches for a node with the specified value in the binary tree starting from the given node.
- `private BinaryTree? Search(int value)`: Searches for a node with the specified value in the binary tree starting from the root node.
- `public bool Remove(int value)`: Removes the node with the specified value from the binary tree.
- `private void Print(BinaryTree? node)`: Recursively prints the nodes of the binary tree in an in-order traversal.
- `public void Print()`: Prints the nodes of the binary tree in an in-order traversal, starting from the root node.
- `public override string ToString()`: Returns a string representation of the current node's value.

## Time Complexities

- `Add`: O(log n) on average (O(n) in the worst case for an unbalanced tree)
- `Search`: O(log n) on average (O(n) in the worst case for an unbalanced tree)
- `Remove`: O(log n) on average (O(n) in the worst case for an unbalanced tree)
- `Print`: O(n) (traverses and prints all nodes)

## Explanation

The BinaryTree class represents a node in the binary tree data structure. Each node contains a value, a reference to its parent node, and references to its left and right child nodes.

The Add method adds a new node with the specified value to the binary tree. It compares the value with the current node's value and recursively adds the new node to the left subtree if it is less than the current value or to the right subtree if it is greater. This process continues until an appropriate position is found.

The Search method searches for a node with the specified value in the binary tree. It performs a recursive search starting from the given node or the root node. It compares the value with the current node's value and traverses to the left subtree if the value is less than the current value or to the right subtree if it is greater. If a node with the specified value is found, it is returned; otherwise, null is returned.

The Remove method removes the node with the specified value from the binary tree. It first searches for the node using the Search method. If the node is found, different cases are considered for removal:

- If the node to remove is the root node, it is replaced by its right child if it exists, or its left child if it doesn't. If the right child exists, the leftmost node in the right subtree is found and replaced with the root node. This ensures that the binary tree remains a valid tree structure.
- If the node to remove is a leaf node (has no children), it is simply removed by updating its parent's reference to null.
- If the node to remove has a left child but no right child, its left child becomes the child of its parent.
- If the node to remove has a right child but no left child, its right child becomes the child of its parent.
- If the node to remove has both a left and right child, the leftmost node in the right subtree is found and replaced with the node to remove. This ensures that the binary tree remains a valid tree structure.

The Print method performs an in-order traversal of the binary tree and prints the nodes in ascending order of their values. It recursively visits the left subtree, prints the current node, and then visits the right subtree.

The Binary Tree data structure provides an efficient way to store and manipulate hierarchical data with a binary relationship between nodes. It is commonly used for various applications such as binary search algorithms, expression trees, and hierarchical representations.

***

# Dictionary Data Structure

The Dictionary class is an implementation of a generic dictionary data structure in C#. It allows you to store key-value pairs, where each key is unique within the dictionary.

## Time Complexity

- Adding an item (Add method): O(1)
- Removing an item (Remove method): O(1)
- Retrieving a value by key (this[] indexer): O(1) average case, O(n) worst case
- Checking if a key exists (ContainsKey method): O(n)
- Counting the number of items (Count property): O(1)

## Description

The Dictionary class maintains two lists, `_keys` and `_values`, to store the keys and corresponding values, respectively. It provides methods to add, remove, and access items based on their keys.

The constructor initializes the empty dictionary by creating the key and value lists. The `Count` property returns the number of items in the dictionary, which is equivalent to the number of keys.

The `Add` method adds a new key-value pair to the dictionary. It checks if the key already exists and throws an `ArgumentException` if a duplicate key is detected. Otherwise, it appends the key and value to their respective lists.

The `Remove` method removes an item from the dictionary based on the provided key. It first finds the index of the key in the `_keys` list and removes the corresponding key and value from both lists. If the key is not found, it returns false.

The `TryGetValue` method attempts to retrieve the value associated with the specified key. It finds the index of the key in the `_keys` list and returns true if the key is found. In that case, it sets the `value` parameter to the corresponding value. If the key is not found, it assigns `default` to `value` and returns false.

The `ContainsKey` method checks if the dictionary contains a specific key. It utilizes the LINQ `Enumerable.Contains` method to search for the key in the `_keys` list. It returns true if the key is found, and false otherwise.

The `this[]` indexer provides a convenient way to access the value associated with a specific key. It retrieves the index of the key in the `_keys` list and returns the corresponding value. If the key is not found, it throws a `KeyNotFoundException`.


***

# Heap

A Heap is a complete binary tree-based data structure that satisfies the heap property. It is commonly used to implement priority queues. The Heap class provided is a Max Heap, where the maximum value is always at the root.

## Methods

- `Add(T value)`: Adds a value to the heap while maintaining the heap property.
- `ExtractMaximum()`: Removes and returns the maximum value from the heap, while maintaining the heap property.

## Time Complexities

- Add: O(log n)
- ExtractMaximum: O(log n)

## Explanation

A Heap is implemented using a List, where each element represents a node in the binary tree. The Heap class ensures that the heap property is maintained during insertion and extraction operations.

The `Add` method adds a value to the heap by appending it to the end of the list and then shifting it up the tree until it satisfies the heap property. This is done recursively in the `ShiftUp` method. The time complexity of adding an element is O(log n) because the element might need to be moved up the tree.

The `ExtractMaximum` method removes and returns the maximum value from the heap, which is always located at the root of the tree. The root is replaced with the last element in the list, and then the element is shifted down the tree until it satisfies the heap property. This is done recursively in the `ShiftDown` method. The time complexity of extracting the maximum value is also O(log n) because the element might need to be moved down the tree.

By using a Max Heap, the Heap data structure allows for efficient retrieval of the maximum value and insertion of new values while maintaining the heap property. This makes it suitable for implementing priority queues and solving various problems that involve prioritizing elements based on their values.


***
