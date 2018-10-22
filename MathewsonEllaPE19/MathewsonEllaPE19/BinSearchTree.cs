using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathewsonEllaPE19
{
    class BinSearchTree
    {

        protected Node root;

        public BinSearchTree()
        {
            root = null;
        }

        public void HardCode()
        {
            root = new Node(23);
            root.Left = new Node(13);
            root.Left.Left = new Node(7);
            root.Left.Right = new Node(18);

            root.Right = new Node(33);
            root.Right.Right = new Node(47);

            root.Display();
        }

    }
}

