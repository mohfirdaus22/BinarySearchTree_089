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


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
