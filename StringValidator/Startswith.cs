using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidator
{
    public class StartsWith : StringValidator
    {
        public bool Start(string data)
        {
            if (data.StartsWith("ex"))
            {
                return false;
            }
            return true;
        }
    }
}
