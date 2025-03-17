using System;
using Classes; 

class Program
{
    static void Main()
    {
        // Creating a Product object
        Product MacBook = new Product("MacBook", 3000.00, 10);
        MacBook.DisplayProductInfo(); 

        // Creating an Electronic object (Fix: use double quotes)
        Electronic MacPro = new Electronic("MacPro", 5000.00, 10, 3);
        MacPro.DisplayElectronicInfo();
    }
}
