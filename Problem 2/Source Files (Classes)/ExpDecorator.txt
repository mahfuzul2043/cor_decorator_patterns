using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS476Project2
{
    class ExpDecorator : Decorator
    {
        private Handler handler;

        public ExpDecorator(Handler handler)
        {
            this.handler = handler;
        }

        public override string GetOutput()
        {
            return Double.Parse(handler.GetOutput()).ToString("E");
        }

        public override string GetUnit()
        {
            return handler.GetUnit();
        }

        public override Handler HandleRequest(string type, string value)
        {
            return handler.HandleRequest(type, value);
        }
    }
}
