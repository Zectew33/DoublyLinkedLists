using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1_Task2
{    //Class for Nodes
    class DLLNode
    {
        public int num;
        public DLLNode next;
        public DLLNode prev;

        //Construtor
        public DLLNode(int num) { next = null; prev = null; this.num = num; }

    }
}
