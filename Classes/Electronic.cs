namespace Classes
{
    public class Electronic : Product
    {
        private int _WarrantyPeriod; //in years
        public Electronic(string Name, double Price, int StockQuantity, int WarrantyPeriod) : base(Name, Price, StockQuantity )
        {
            _WarrantyPeriod = WarrantyPeriod;
        }

         public int WarrantyPeriod
        {
            get { return _WarrantyPeriod; }
            set { _WarrantyPeriod = value; }
        }

        public void DisplayElectronicInfo()
        {
            DisplayProductInfo();
            Console.WriteLine($"Warranty Period is {_WarrantyPeriod} years.");
        }
    }
}