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

        public void handle()
        {
            message();
        }

        public void message()
        {
            handler("Input Exceeded the Allowed Limit");          
        }
    }
}
