
using EsameTesting.Objects;
using System.Runtime.Intrinsics;
using Xunit;
using Xunit.Abstractions;

namespace EsameTesting
{
    public class Testing
    {

        [Fact]
        public void Example1()
        {
            P p1 = new(100);
            V v1 = new(100, p1);
            V v2 = new(100, p1);
            G g1 = new(100, v1);
            G g2 = new(100, v1);
            G g3 = new(100, v2);
            G g4 = new(100, v2);
            PVG G1 = new(p1, v1, g1);
            PVG G2 = new(p1, v1, g2);
            PVG G3 = new(p1, v2, g3);
            PVG G4 = new(p1, v1, g4);
            var result = Checker.CheckPath(G1, G2, G3, G4);
            Assert.Equal(G1, result);
        }

        [Fact]
        public void Example2()
        {
            P p1 = new(50);
            V v1 = new(50, p1);
            V v2 = new(100, p1);
            G g1 = new(50, v1);
            G g2 = new(100, v1);
            G g3 = new(100, v2);
            G g4 = new(100, v2);
            PVG G1 = new(p1, v1, g1);
            PVG G2 = new(p1, v1, g2);
            PVG G3 = new(p1, v2, g3);
            PVG G4 = new(p1, v1, g4);

            var result = Checker.CheckPath(G1, G2, G3, G4);
            Assert.Equal(new PVG(p1, v2, g2), result);
        }

    }
}
