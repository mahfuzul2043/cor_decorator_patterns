﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS476Project2
{
    class FootHandler : Handler
    {
        private string output;

        public override string GetOutput()
        {
            return output;
        }

        public override string GetUnit()
        {
            return "Feet";
        }

        public override Handler HandleRequest(string type, string value)
        {
            if (type.Equals("Foot"))
            {
                if (Double.TryParse(value, out double result))
                {
                    output = (result * 3280.84).ToString();
                    return this;
                }
                else
                {
                    throw new FormatException("Invalid format. Input should be a integer or real number.");
                }
            }
            else
            {
                if (successor != null)
                {
                    return successor.HandleRequest(type, value);
                }
                return null;
            }
        }
    }
}
