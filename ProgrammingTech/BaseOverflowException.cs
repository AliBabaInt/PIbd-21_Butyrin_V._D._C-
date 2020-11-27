using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingTech
{
    public class BaseOverflowException : Exception
    {
        public BaseOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}
