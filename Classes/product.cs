using System.Diagnostics.Tracing;

namespace Classes
{
    public class Product 
    {
        private string _Name;
        private double _Price; 
        private int _StockQuantity;

        public Product(string Name, double Price, int StockQuantity)
        {
            _Name = Name;
            _Price = Price;
            _StockQuantity = StockQuantity; 
        }        

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Info:{_Name} for ${_Price} with {_StockQuantity} in Stock");
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public int StockQuantity
        {
            get { return _StockQuantity; }
            set { _StockQuantity = value; }
        }

        
    }
}