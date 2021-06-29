using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidator
{
    public class IsNullOrEmpty : IValidator
    {
        
        public bool IsValidString(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            return true;
        }
    }
}
