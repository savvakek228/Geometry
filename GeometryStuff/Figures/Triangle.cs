using System.Collections.Generic;

namespace GeometryStuff.Figures
{
    public record Triangle : Figure
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
    }
}