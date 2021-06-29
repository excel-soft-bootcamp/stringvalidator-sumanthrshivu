using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidator
{
    public class StringValidator
    {
        IValidator _validate;

        public StringValidator(IValidator validate)
        {
            this._validate = validate;
        }

        public bool CheckValidString(string data)
        {
            return _validate.IsValidString(data);
        }
    }
}
