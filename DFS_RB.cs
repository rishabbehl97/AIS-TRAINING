using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.RB
{
        public class NodeStructureDFS                   // Structure of a new node created.
        {
            public int data;
            public NodeStructureDFS left, right;
            public NodeStructureDFS(int item)
            {
                data = item;
                left = right = null;
            }
        }

    public class DFS_RB
    {
        public NodeStructureDFS root;              // Root of the Binary Tree  

        public DFS_RB()
        {
            root = null;
        }


        public void InorderTraversal(NodeStructureDFS node)  //Inorder traversal way of DFS
        {
            if (node == null)
            {
                return;
            }

            InorderTraversal(node.left);
            Console.Write(node.data + " ");
            InorderTraversal(node.right);
        }


        public void PreorderTraversal(NodeStructureDFS node)  //Preorder traversal way of DFS
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.data + " ");
            PreorderTraversal(node.left);
            PreorderTraversal(node.right);
        }


        public void PostorderTraversal(NodeStructureDFS node) //Postorder traversal way of DFS
        {
            if (node == null)
            {
                return;
            }

            PostorderTraversal(node.left);
            Console.Write(node.data + " ");
            PostorderTraversal(node.right);
        }

        void printPostorder()
        {
            PostorderTraversal(root);
        }

        void printInorder()
        {
            InorderTraversal(root);
        }

        void printPreorder()
        {
            PreorderTraversal(root);
        }

        public static void Main(String[] args)
        {
            DFS_RB treeDFS = new DFS_RB();

            treeDFS.root = new NodeStructureDFS(1);

            treeDFS.root.left = new NodeStructureDFS(2);
            treeDFS.root.right = new NodeStructureDFS(3);

            treeDFS.root.left.left = new NodeStructureDFS(4);
            treeDFS.root.left.right = new NodeStructureDFS(5);
            treeDFS.root.right.left = new NodeStructureDFS(6);

            Console.WriteLine("\n *******MENU*******"
                                          + "\n 1. INORDER TRAVERSAL"
                                          + "\n 2. PREORDER TRAVERSAL"
                                          + "\n 3. POSTORDER TRAVERSAL"
                                          + "\n 4. EXIT");
            Console.WriteLine(" Enter the way in which you want to traverse and search for elemeent in the tree?");

            string myChoiceDFS;
            myChoiceDFS = Console.ReadLine();
            int choiceDFS = Convert.ToInt32(myChoiceDFS);

            switch (choiceDFS)
            {
                case 1: treeDFS.printInorder();
                    break;
                case 2: treeDFS.printInorder();
                    break;
                case 3: treeDFS.printPostorder();
                    break;
                case 4:
                    break;
                default: Console.WriteLine(" Wrong Choice. Better luck next time!!");
                    break;
            }
            Console.Read();
        }


    }
}
