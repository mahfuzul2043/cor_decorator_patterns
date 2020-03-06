using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS476Project2
{
    abstract class Handler
    {
        protected Handler successor;
        public abstract string HandleRequest(string type, string value);
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
    }
}
