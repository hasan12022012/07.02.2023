using System;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook product1=new Notebook("asus", "FX506L");
            product1.Price = 3000;
            product1.ShowInfo();

            Notebook product2 = new Notebook("apple", "MacBookPro");
            product2.Price = 3500;
            product2.ShowInfo();

            Notebook product3 = new Notebook("hp", "pavilion");
            product3.Price =2000 ;
            product3.ShowInfo();


            Notebook[] arr= new Notebook[] {product1, product2,product3};

            var sum = 0;
            var count=0;
            for(int i=0; i<arr.Length; i++)
            {
                sum += arr[i].Price;
                count++;
            }
            Console.WriteLine($"qiymetlerin ortalaması: {sum/count}");





        }
    }
}
