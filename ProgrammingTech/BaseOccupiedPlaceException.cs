using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingTech
{
    class BaseOccupiedPlaceException : Exception
    {
        public BaseOccupiedPlaceException() : base("Место уже занято")
        { }
    }
}
