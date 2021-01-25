using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDependencyInjectionNoParams
{
    public class Circle : IShape<Circle>
    {
        public Circle()
        {
        }
    }
}
