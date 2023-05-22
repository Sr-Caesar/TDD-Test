

namespace EsameTesting.Objects
{
    public class PVG
    {
        private readonly P _p;
        private readonly V _v;
        private readonly G _g;
        public P GetP {get { return _p; } }
        public V GetV {get {return _v; } }
        public G GetG {get { return _g; } }
        public PVG(P p, V v, G g)
        {
            _p = p;
            _v = v;
            _g = g;
        }
    }
}
