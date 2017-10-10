using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacker
{
    public class StackClass
    {
        // private bool isEmpty = true;
        private ArrayList elements = new ArrayList();
 
        public bool IsEmpty
        {
            get
            {
                return (elements.Count == 0);
            }
        }

        public void Push(object element)
        {
            this.elements.Insert(0, element);
        }

        public object Pop()
        {
            if(IsEmpty)
            {
                
            }
      
            // object top = this.elements(count -1);
            // this.elements.RemoveAt(count -1);


            object top = elements[0];
            elements.RemoveAt(0);

            return top; 
        }

    }
}
