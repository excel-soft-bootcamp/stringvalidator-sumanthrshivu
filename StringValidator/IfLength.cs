using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidator
{
    public class IfLength : IValidator
    {
        public bool IsValidString(string data)
        {
            if (data.Length > 8)
            {
                return false;
            }
            return true;
        }
    }
}
