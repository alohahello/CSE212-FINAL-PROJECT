# INTRODUCTION TO TREES IN DATA STRUCTURES

A tree is a hierarchical data structure that consists of nodes connected by edges. It starts with a root node and each node has zero or more child nodes. The node at the top is called the root, and nodes with no children are called leaves. The nodes in a tree are often referred to as parent, child, and sibling nodes based on their relationships.

## KEY TERMINOLOGY:

* Root: The topmost node in a tree.
* Node: An element in a tree that can have zero or more children.
* Parent: A node that has one or more child nodes.
* Child: A node directly connected to another node when moving away from the root.
* Leaf: A node with no children.
* Subtree: A tree formed by a node and its descendants.
* Depth: The level or distance of a node from the root.
* Height: The length of the longest path to a leaf from a node.

## COMMON TYPES OF TREES:

### 1. Binary Tree:
A binary tree is a tree in which each node has at most two children, referred to as the left child and the right child.

### 2. Binary Search Tree (BST):
A binary search tree is a binary tree with the additional property that the left subtree of a node contains only nodes with keys less than the node's key, and the right subtree contains only nodes with keys greater than the node's key.

### 3. AVL Tree:
An AVL tree (Adelson-Velsky and Landis tree) is a self-balancing binary search tree, where the heights of the two child subtrees of every node differ by at most one.

## BASIC TREE OPERATIONS:

* Traversal: Visiting all the nodes in a tree in a specific order.
* Insertion: Adding a new node to the tree.
* Deletion: Removing a node from the tree.
* Searching: Finding a specific node in the tree.

# EXAMPLE OF A BINARY TREE IN C#:
``` C#

public class TreeNode
{
    public int Data;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    public TreeNode Root;

    public BinaryTree()
    {
        Root = null;
    }

    // Methods for tree operations (e.g., traversal, insertion, deletion) can be implemented here.
}

```

# EXAMPLE OF A BINARY SEARCH TREE (BST) IN C#:

``` C#

public class BinarySearchTreeNode
{
    public int Data;
    public BinarySearchTreeNode Left;
    public BinarySearchTreeNode Right;

    public BinarySearchTreeNode(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public BinarySearchTreeNode Root;

    public BinarySearchTree()
    {
        Root = null;
    }

    // Methods for BST operations (e.g., insertion, deletion, searching) can be implemented here.
}

```

SEGUIR CON EL EJEMPLO COMPLETO EN OTRO FILE AND HAD A LINK 