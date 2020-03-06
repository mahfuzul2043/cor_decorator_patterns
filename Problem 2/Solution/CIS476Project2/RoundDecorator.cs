using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS476Project2
{
    class RoundDecorator : Decorator
    {
        private Handler handler;

        public RoundDecorator(Handler handler)
        {
            this.handler = handler;
        }

        public override string GetOutput()
        {
            return Math.Round(Double.Parse(handler.GetOutput()), 2).ToString();
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
