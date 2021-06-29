using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidator
{
    public class IsNullOrEmpty : IStringValidator
    {
        public bool IsEmptyOrNull(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            return true;
        }
    }
}
