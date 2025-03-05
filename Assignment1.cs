using System;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        { 
            Object[,] products = new Object[,]
            { 
                {"Lamp", "Electronics", 4000, 12},
                {"Tv", "Electronics", 68000, 9},
                {"Refrigerator", "Electronics", 93000, 8},
                {"Oven", "Electronics", 70000, 5},
                {"Bulb", "Electronics", 300, 12}
            };
             
            Console.WriteLine("------------------Products Details-----------------\n");
            Console.ReadKey(); 
            int position = 0;
            foreach (var item in products)
            {
                int row =position  / products.GetLength(1);
                int coloumn = position %products.GetLength(1); 
                if (coloumn == 0)
                {
                    String ProductName = (String)products[row, 0];
                    String Category =(String)products[row, 1];
                    Double Price = Convert.ToDouble(products[row, 2]);  
                    int QuantityinStock = (int)products[row, 3]; 
                    Console.WriteLine (" Product_Name: {0} \n Category: {1} \n Price: {2} \n Quantity_Available: {3} \n",  ProductName, Category, Price, QuantityinStock );
                } 
                position++;
            } 

            Console.WriteLine("---------Calculate each product price-------------------------\n");
            Console.ReadKey();
            Double TotalStockprice = 0;
            position = 0;  
            foreach (var item in products)
            { 
                int row = position / products.GetLength(1);
                int column = position % products.GetLength(1); 
                if (column ==0)  
                { String ProductName =(String)products [row, 0];
                    Double Price = Convert.ToDouble(products[row, 2]);  
                    int QuantityinStock = (int)products[row, 3];
                    Double ProductStockprice = Price * QuantityinStock; 
                    Console.WriteLine ("\t Product_Name: {0} \n\t Total quantity of product price: {1} \n", ProductName, ProductStockprice) ; 
                    TotalStockprice += ProductStockprice;

                }

                position++;
            } 
            Console.WriteLine(String.Format("\nTotal payment: {0}", TotalStockprice));  
            Console.ReadKey();  

        }
    }
}