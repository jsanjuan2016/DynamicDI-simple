using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDependencyInjectionNoParams
{
    public class Rectangle : IShape<Rectangle>
    {
        public Rectangle()
        {
        }
    }
}
