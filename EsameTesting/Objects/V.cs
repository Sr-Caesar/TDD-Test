

namespace EsameTesting.Objects
{
    public class V : P
    {
        private readonly P _pFather;
        private readonly int _price;
        private readonly int _id;

        private static int ID = 0;
        public P GetFather {get {return _pFather;}}
        public new string Name { get { return $"{_pFather.Name}-V{_id}"; } }
        public new int Price { get { return _price; } }
        public V(int price,P father) : base(price)
        {
            ID++;
            _price = price;
            _pFather = father;
            _id = ID;
        }
    }
}
