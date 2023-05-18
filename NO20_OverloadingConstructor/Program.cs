namespace NO20_OverloadingConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO 20 : Overloading Constructor */
            Console.WriteLine("Topic NO 20 : Overloading Constructor");
            Console.WriteLine();

            Product product = new Product(1, "Bearbrand", "Philippines Milk Product", 100, 8.75F);
            Product productNoDesc = new Product(1, "Alaska", 50, 7.75F);

            Console.WriteLine("Product with Description");
            Console.WriteLine("Product Serial ID : {0}", product.productID);
            Console.WriteLine("Name              : {0}", product.productName);
            Console.WriteLine("Description       : {0}", product.productDesc);
            Console.WriteLine("Stock             : {0}", product.productStock);
            Console.WriteLine("Price             : {0}", product.productPrice);

            Console.WriteLine();

            Console.WriteLine("Product w/out Description");
            Console.WriteLine("Product Serial ID : {0}", productNoDesc.productID);
            Console.WriteLine("Name              : {0}", productNoDesc.productName);
            Console.WriteLine("Stock             : {0}", productNoDesc.productStock);
            Console.WriteLine("Price             : {0}", productNoDesc.productPrice);
        }
    }
}