using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class TextLimit
    {
        public delegate void LimitHandler(String txt);
        public LimitHandler handler;

        public void handle(bool value)
        {
            message(value);
        }

        public void message(bool value)
        {
            handler("Input Exceeded the Allowed Limit");
        }
    }
}
