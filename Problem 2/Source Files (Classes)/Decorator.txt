using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS476Project2
{
    abstract class Decorator : Handler
    {
        public override string GetOutput()
        {
            return "";
        }

        public override string GetUnit()
        {
            return "";
        }

        public override Handler HandleRequest(string type, string value)
        {
            return null;
        }
    }
}
