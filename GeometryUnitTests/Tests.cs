using System;
using System.Collections.Generic;
using GeometryStuff;
using GeometryStuff.Figures;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace GeometryUnitTests
{
    [TestFixture]
    public class Tests
    {
        protected Triangle Triangle = new()
            { FigureType = FigureType.IsTriangle, SideA = 3, SideB = 5, SideC = 4 };

        protected RadialFigure Round = new() { FigureType = FigureType.IsRadial, Radius = 5 };

        protected RegularPolygon RegularPolygon = new()
            { FigureType = FigureType.IsRegularPolygon, Apophema = 10*Math.Sqrt(3), Side = 20, SideAmount = 6 };

        protected NonRegularPolygon NonRegularPolygon = new()
            { FigureType = FigureType.IsNonRegularPolygon, PikesCoordinates
                = new Dictionary<double, double>{ {-3, -2}, {-1, 4}, {6, 1}, {3, 10}, {-4, 9} } };
        
        protected FigureProcessor Processor = new FigureProcessor();

        [Test]
        public void TestTriangle()
        {
            Assert.AreEqual(6, Processor.ProcessFigure(Triangle));
        }

        [Test]
        public void TestRound()
        {
            Assert.AreEqual(78.5, Math.Round(Processor.ProcessFigure(Round), 1));
        }

        [Test]
        public void TestRegularPolygon()
        {
            Assert.AreEqual(1039.2, Math.Round(Processor.ProcessFigure(RegularPolygon), 1));
        }

        [Test]
        public void TestNonRegularPolygon()
        {
            Assert.AreEqual(60, Processor.ProcessFigure(NonRegularPolygon));
        }


    }
}