using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDependencyInjectionNoParams
{
    public class WindowManager
    {
        private readonly IShape<Rectangle> _rectangle;
        private readonly IShape<Circle> _circle;

        public WindowManager(IShape<Rectangle> rectangle, IShape<Circle> circle)
        {
            this._rectangle = rectangle ?? throw new ArgumentNullException(nameof(rectangle));
            this._circle = circle ?? throw new ArgumentNullException(nameof(circle));
        }

        public void Show()
        {
            Console.WriteLine($"Rectangle created: { this._rectangle is Rectangle}");
            Console.WriteLine($"Circle created: {this._circle is Circle}");
        }
    }
}
