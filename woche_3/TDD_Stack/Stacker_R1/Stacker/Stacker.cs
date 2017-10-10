using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacker
{
    public class StackClass
    {
        private bool isEmpty = true;

        private object element;

       


        public bool IsEmpty
        {
            get
            {
                return isEmpty;
            }
        }

        public void Push(object element)
        {
            this.element = element;
            isEmpty = false;
        }

        public object Pop()
        {
            isEmpty = true;
            object top = this.element;
            this.element = null;
            return top;
        }
    }
}
