using System;
using System.Collections.Generic;


namespace Binary_search_tree_Breadth_First__Depth_First
{
    // Class to define the nodes

    class Node
    {
        public int data;
        public Node left;
        public Node right;
    }

    //Class to define the Binary Search Tree
    class Tree
    {
        public Node Insert(Node root, int value)
        {
            //If the root node is empty create a new node
            if (root == null)
            {
                root = new Node();
                root.data = value;
            }
            //If the value is less than the value in the root node add it to the left
            else if (value < root.data)
            {
                root.left = Insert(root.left, value);
            }
            //If the value is greater than the value in the root node add it to the right
            else
            {
                root.right = Insert(root.right, value);
            }

            return root;
        }
        public void DisplayBF(Node root)
        {
            // breadth-first using a queue

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                Node n = q.Dequeue();     // Displaying the node by using dequeue
                Console.WriteLine(n.data);
                if (n.left != null)
                    q.Enqueue(n.left);
                if (n.right != null)
                    q.Enqueue(n.right);
            }
        }

        public void DisplayDF(Node root)
        {
            // depth-first using a stack
            Stack<Node> s = new Stack<Node>();
            s.Push(root);
            while (s.Count > 0)
            {
                Node n = s.Pop();
                Console.WriteLine(n.data);
                if (n.left != null)
                    s.Push(n.left);
                if (n.right != null)
                    s.Push(n.right);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            Tree bst = new Tree();
            root = bst.Insert(root,50); // level 0

            root = bst.Insert(root, 30); // level 1
            root = bst.Insert(root, 10); // level 2
            root = bst.Insert(root, 20); // level 3

            root = bst.Insert(root, 80); // level 1
            root = bst.Insert(root, 60); // level 2
            root = bst.Insert(root, 70); // level 3

            bst.DisplayBF(root);
           

            Console.WriteLine();

            bst.DisplayDF(root);


            Console.ReadKey();
        }
        


    }
}
// Retrieved from https://github.com/t1he1maur10ra/6211BstTraversal/blob/master/BstTraversal/BstTraversal/Program.cs

// Retrieved from https://jamesmccaffrey.wordpress.com/2011/10/22/breadth-first-and-depth-first-traversal-of-a-c-binary-search-tree/