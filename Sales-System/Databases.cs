using System;
using System.Collections.Generic;
using System.Text;
using Sales_System;

namespace Sales_System
{
    public class Databases
    {
        Seller[] Sellers = new Seller[20];
        int sellerCount = 0;

        Product[] Products = new Product[20];
        int productCount = 0;

        Sale[] Sales = new Sale[20];
        int saleCount = 0;

        public void AddSeller(Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }

        public void AddSale(Sale newSale)
        {
            Sales[saleCount] = newSale;
            saleCount++;
        }
        // PRODUCTO MAS ECONOMICO
        public void saleCheapest()
        {
            int salepricetemp = this.Sales[0].price;
            string salenametemp = this.Sales[0].seller;

            for (int i = 0; i < this.Sales.Length; i++)
            {
                if (this.Sales[i] != null)
                {
                    if (this.Sales[i].price < salepricetemp)
                    {
                        salepricetemp = this.Sales[i].price;
                        salenametemp = this.Sales[i].seller;
                    }
                }
            }

            Console.WriteLine("the seller who sold the cheapest product was " + salenametemp);

        }
        // PROMEDIO DE VALOR DE PRODUCTOS
        public void averagePrice()
        {
            int sumarypricetemp = 0;
            int amountpricetemp = 0;

            for (int i = 0; i < this.Products.Length; i++)
            {
                if (this.Products[i] != null)
                {
                    sumarypricetemp = sumarypricetemp + this.Products[i].productprice;
                    amountpricetemp++;

                }
            }

            Console.WriteLine("the average price is " + (sumarypricetemp/amountpricetemp));
        }

        public void productUnit(string nameProduct)
        {
            int countTemp = 0;

            for (int i = 0; i < this.Sales.Length; i++)
            {
                if (this.Sales[i] != null)
                {
                    if (this.Sales[i].product == nameProduct)
                    {
                        countTemp++;

                    }
                }
            }

            Console.WriteLine("the product " + nameProduct + " has been sold " + countTemp);
        }

        public void expensiveProduct()
        {
            int productpricetemp = this.Products[0].productprice;
            string productnametemp = this.Products[0].productname;

            for (int i = 0; i < this.Products.Length; i++)
            {
                if (this.Products[i] != null)
                {
                    if (this.Products[i].productprice > productpricetemp)
                    {
                        productpricetemp = this.Products[i].productprice;
                        productnametemp = this.Products[i].productname;
                    }
                }
            }

            Console.WriteLine("the most expensive product was " + productnametemp + " worth " + productpricetemp );

        }
    }
}