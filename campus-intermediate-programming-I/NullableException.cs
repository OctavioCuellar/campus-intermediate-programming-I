using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace campus_intermediate_programming_I
{
    public class NullableException : NullReferenceException

    {
        public NullableException()
        {
            Console.WriteLine("El valor es nulo");
        }
    }
}
