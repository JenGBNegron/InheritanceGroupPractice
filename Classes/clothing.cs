namespace Classes
{
    public class Clothing : Product
    {
        private string _Size;

        public Clothing(string name, double price, int stockQuantity, string size)
            : base(name, price, stockQuantity)
        {
            _Size = size;
        }

        public string Size
        {
            get { return _Size; }
            set { _Size = value; }
        }

        public void DisplayClothingInfo()
        {
            DisplayProductInfo();
            Console.WriteLine($"Size: {_Size}");
        }
    }
}
