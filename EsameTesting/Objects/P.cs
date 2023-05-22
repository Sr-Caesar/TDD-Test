
namespace EsameTesting.Objects
{   
    public class P 
    {
        private readonly int _price;
        private readonly int _id;
        private static int ID = 0;
        public string Name { get { return $"P{_id}"; } }
        public int Price { get { return _price; } }
        public P(int price)
        {
            ID++;
            _price = price;
            _id = ID;
        }
    }
}
