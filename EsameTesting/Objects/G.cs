
using System.Dynamic;

namespace EsameTesting.Objects
{
    public class G : V
    {
        private readonly V _vFather;
        private readonly int _id;
        private readonly int _price;
        private static int ID = 0;
        public new V GetFather {get { return _vFather; } }
        public new int Price { get { return _price; } }
        public new string Name { get { return $"{_vFather.Name}-G{_id}"; } }
        public G(int price, V father) : base(price, father)
        {
            ID++;
            _price = price;
            _vFather = father;
            _id = ID;
        }
        
    }
}
