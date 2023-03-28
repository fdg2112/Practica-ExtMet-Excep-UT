using System;

namespace TP3_Logic
{
    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base("Error personalizado: " + message)
        {
        }
    }
}
