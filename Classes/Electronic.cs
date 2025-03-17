namespace Classes
{
    public class Electronic : Product
    {
        private int _WarrantyPeriod; //in years
        public Electronic(int WarrantyPeriod) : base(string Name, double Price, int StockQuantity)
        {
            _WarrantyPeriod = WarrantyPeriod;
        }

         public string WarrantyPeriod
        {
            get { return _WarrantyPeriod; }
            set { _WarrantyPeriod = value; }
        }
    }
}