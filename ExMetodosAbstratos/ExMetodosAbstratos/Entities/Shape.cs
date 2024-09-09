using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExMetodosAbstratos.Entities.Enums;

namespace ExMetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape() { }
        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
