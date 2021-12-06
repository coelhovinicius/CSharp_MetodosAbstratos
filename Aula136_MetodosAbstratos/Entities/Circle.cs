/* >>> CLASSE CIRCLE <<< */
using System;
using Aula136_MetodosAbstratos.Entities.Enums;

namespace Aula136_MetodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
