using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingTech
{
    public class BaseNotFoundException : Exception
    {
        public BaseNotFoundException(int i) : base("Не найден автомобиль по месту " + i)
        { }
    }
}
