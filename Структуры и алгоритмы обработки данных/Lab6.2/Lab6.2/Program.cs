using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
    internal class Program
    {
        class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int value)
            {
                this.value = value;
                this.left = null;
                this.right = null;
            }
        }

        class BinarySearchTree
        {
            private Node root;

            public BinarySearchTree()
            {
                this.root = null;
            }

            public void Insert(int value)
            {
                Node newNode = new Node(value);

                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    Node current = root;
                    Node parent;

                    while (true)
                    {
                        parent = current;

                        if (value < current.value)
                        {
                            current = current.left;

                            if (current == null)
                            {
                                parent.left = newNode;
                                break;
                            }
                        }
                        else
                        {
                            current = current.right;

                            if (current == null)
                            {
                                parent.right = newNode;
                                break;
                            }
                        }
                    }
                }
            }

            public bool Search(int value)
            {
                Node current = root;

                while (current != null)
                {
                    if (value == current.value)
                    {
                        return true;
                    }
                    else if (value < current.value)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current = current.right;
                    }
                }

                return false;
            }

            public bool Delete(int value)
            {
                Node current = root;
                Node parent = root;
                bool isLeftChild = true;

                while (current.value != value)
                {
                    parent = current;

                    if (value < current.value)
                    {
                        isLeftChild = true;
                        current = current.left;
                    }
                    else
                    {
                        isLeftChild = false;
                        current = current.right;
                    }

                    if (current == null)
                    {
                        return false;
                    }
                }

                if (current.left == null && current.right == null)
                {
                    if (current == root)
                    {
                        root = null;
                    }
                    else if (isLeftChild)
                    {
                        parent.left = null;
                    }
                    else
                    {
                        parent.right = null;
                    }
                }
                else if (current.right == null)
                {
                    if (current == root)
                    {
                        root = current.left;
                    }
                    else if (isLeftChild)
                    {
                        parent.left = current.left;
                    }
                    else
                    {
                        parent.right = current.left;
                    }
                }
                else if (current.left == null)
                {
                    if (current == root)
                    {
                        root = current.right;
                    }
                    else if (isLeftChild)
                    {
                        parent.left = current.right;
                    }
                    else
                    {
                        parent.right = current.right;
                    }
                }
                else
                {
                    Node successor = GetSuccessor(current);

                    if (current == root)
                    {
                        root = successor;
                    }
                    else if (isLeftChild)
                    {
                        parent.left = successor;
                    }
                    else
                    {
                        parent.right = successor;
                    }

                    successor.left = current.left;
                }

                return true;
            }

            private Node GetSuccessor(Node node)
            {
                Node parentSuccessor = node;
                Node successor = node;
                Node current = node.right;

                while (current != null)
                {
                    parentSuccessor = successor;
                    successor = current;
                    current = current.left;
                }

                if (successor != node.right)
                {
                    parentSuccessor.left = successor.right;
                    successor.right = node.right;
                }

                return successor;
            }

            void PrintTree(Node node)
            {
                if (node == null)
                    return;
                Console.Write(node.value + " ");

                PrintTree(node.left);
                PrintTree(node.right);
                
            }

            public void PrintTree()
            {
                PrintTree(root);
            }
        }
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(80);


            Console.WriteLine("Дерево до удаления: ");
            bst.PrintTree();

            Console.WriteLine("\nУдаляем 20 и 80: ");
            bst.Delete(20);
            bst.Delete(80);
            
            Console.WriteLine("\nДерево после удаления: ");
            bst.PrintTree();
        }
    }
}
