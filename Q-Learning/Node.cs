using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q_Learning
{
    class Node
    {
        public NewPanel panel;

        public bool Wall;
        public bool Cheese;
        public bool None;
        public bool Agent;
        public bool Cat;

        public int X;
        public int Y;
        public int state;

        public Node(NewPanel panel, int Y, int X)
        {
            Cat =  Wall = Cheese = Agent =  false;
            None = true;

            this.X = X;
            this.Y = Y;
            this.panel = panel;
        }
    }
}
