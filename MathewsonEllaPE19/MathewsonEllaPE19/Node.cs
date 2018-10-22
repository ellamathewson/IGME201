using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathewsonEllaPE19
{
    class Node
    {

        protected int data;
        protected Node left;
        protected Node right;

        public Node(int pData)
        {
            //this.data is calling the data value in the class
            this.data = pData;
        }

        public void Display()
        {
            Console.WriteLine(data);
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }


    }
}
