using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

    }

    public class BinaryTree
    {
        public void Insert(Node head, int value)
        {

            while(head != null)
            {
                if(value > head.data)
                {
                    if(head.right == null)
                    {
                        head.right = new Node();
                        head = head.right;
                        head.data = value;

                        break;
                    }
                    else
                    { 
                        head = head.right;
                    }
                    
                }

                else
                {
                    if(head.left == null)
                    {
                        head.left = new Node();
                        head = head.left;
                        head.data = value;

                        break;
                    }
                    else
                    {
                        head = head.left;
                    }

                }
            }
           //if(head == null)
           // {
           //     head = new Node();
           //     head.data = value;
           // }
        }

        void Size(Node head)
        {

        }
    }

}

