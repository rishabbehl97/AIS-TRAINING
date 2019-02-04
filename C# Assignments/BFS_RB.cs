using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.RB
{

    public class NodeStructure                   // Structure of a new node created.
    {
        public int data;
        public NodeStructure left, right;
        public NodeStructure(int item)
        {
            data = item;
            left = right = null;
        }
    }

    class BFS_RB
    {

        public NodeStructure root;              // Root of the Binary Tree  

        public BFS_RB()
        {
            root = null;
        }

        public virtual void levelWiseTravel()   //function to print level order traversal of tree
        {
            int h = height(root);
            int i;
            for (i = 1; i <= h; i++)
            {
                levelWiseTravel(root, i);
            }
        }


        public virtual int height(NodeStructure root) // Compute the "height" of a tree

        {
            if (root == null)
            {
                return 0;
            }
            else
            {

                int lheight = height(root.left);
                int rheight = height(root.right);

                if (lheight > rheight)
                {
                    return (lheight + 1);
                }
                else
                {
                    return (rheight + 1);
                }
            }
        }


        public virtual void levelWiseTravel(NodeStructure root, int level)  // Print nodes at the given level 
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.data + " ");
            }
            else if (level > 1)
            {
                levelWiseTravel(root.left, level - 1);
                levelWiseTravel(root.right, level - 1);
            }
        }


            /*     public static void Main(string[] args)
                 {
                     BFS_RB tree = new BFS_RB();

                     tree.root = new NodeStructure(1);

                     tree.root.left = new NodeStructure(2);
                     tree.root.right = new NodeStructure(3);

                     tree.root.left.left = new NodeStructure(4);
                     tree.root.left.right = new NodeStructure(5);
                     tree.root.right.left = new NodeStructure(6);

                     Console.WriteLine("BFS of binary tree is :");
                     tree. levelWiseTravel();

                     Console.Read();
                 }
             */
             
    }
}

