using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidator
{
    public class IfLength : StringValidator
    {
        public bool Length(string data)
        {
            if (data.Length > 8)
            {
                return false;
            }
            return true;
        }
    }
}
