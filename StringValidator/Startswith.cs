using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidator
{
    public class StartsWith : IValidator
    {
        public bool IsValidString(string data)
        {
            if (data.StartsWith("ex"))
            {
                return false;
            }
            return true;
        }
    }
}
