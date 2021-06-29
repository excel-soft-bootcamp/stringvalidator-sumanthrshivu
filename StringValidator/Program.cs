using System;

namespace StringValidator
{
    class Program
    {
        static void Main()
        {
            IsNullOrEmpty _nullOrEmptyString = new IsNullOrEmpty();
            StringValidator _validateNullOrEmpty = new StringValidator(_nullOrEmptyString);
            _validateNullOrEmpty.CheckValidString(null);

            IfLength _length = new IfLength();
            StringValidator _validateLength = new StringValidator(_length);
            _validateLength.CheckValidString("string");

            StartsWith _startsWith = new StartsWith();
            StringValidator _validateStartsWith = new StringValidator(_startsWith);
            _validateStartsWith.CheckValidString("ex");

        }
    }
}
