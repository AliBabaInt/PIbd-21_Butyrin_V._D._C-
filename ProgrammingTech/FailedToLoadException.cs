using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingTech
{
    class FailedToLoadException : Exception
    {
        public FailedToLoadException() : base("Не удалось загрузить автомобиль на парковку")
        { }
    }
}
