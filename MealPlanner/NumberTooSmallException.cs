using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlan
{
    [Serializable]
    public class NumberTooSmallException : Exception
    {

        public NumberTooSmallException() { }
        public NumberTooSmallException(string message) : base(message) { }

        public NumberTooSmallException(string message, Exception innerException)
            : base(message, innerException) { }

    }
}
