using System;

namespace lab3.Exceptions
{
    public class MyException : Exception
    {
        public MyException() : base("This item not found in the collection."){}
    }
}
