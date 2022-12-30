using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_089
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;

        }
    }
    // A node class consist os three things, the information, referenceto the
    // right child, and reference to the left child

    class BinaryTree
    {
        public Node ROOT;

        public BinaryTree()
        {
            ROOT = null; // Initializing ROOT to null
        }

        public void insert(string element) // insert a node in the binarry search tree
        {
            Node tmp, parent = null, currentNode = null;
            Search(element, ref parent, ref currentNode);
            if (currentNode != null)  //check if the node to be inserted already inserted or not
            {
                Console.WriteLine(" Duplicated words not allowed");
                return;
            }
            else  // if the specified node is not present
            {
                 tmp = new Node(element, null, null); //creates a Node
                if (parent == null) //if the tree is empty
                {
                    ROOT = tmp;
                }
                else if (String.Compare(element,parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }

        public void Search(String element, ref Node parent, ref Node currentNode)
        {
            //This function searches the currentNode of the specified node as
            //well as the current Node of its parent

        currentNode = ROOT;
            parent = null;
            while ((currentNode !=null) && (currentNode.info != element))
            {
                parent = currentNode;   
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }

        public void inorder(Node ptr)
        {
            if  ( ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if(ptr!= null)
            {
                inorder(ptr.leftchild);
                Console.Write(ptr.info + " ");
                inorder(ptr.rightchild);
            }
        }

        public void preorder (Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return ;
            }
            if (ptr != null)
            {
                Console.Write(ptr.info + " ");
                preorder(ptr.leftchild);
                preorder(ptr.rightchild);
            }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
