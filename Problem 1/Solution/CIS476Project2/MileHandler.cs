﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS476Project2
{
    class MileHandler : Handler
    {
        public override string HandleRequest(string type, string value)
        {
            if (type.Equals("Mile"))
            {
                if (Double.TryParse(value, out double result))
                {
                    return (result / 1.609).ToString();
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
