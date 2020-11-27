using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingTech
{
    class WrongFormatException : Exception
    {
        public WrongFormatException() : base("Неверный формат файла")
        { }
    }
    
}
