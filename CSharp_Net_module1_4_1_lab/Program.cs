using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9) declare object of OnlineShop 
            OnlineShop on = new OnlineShop();
            
            // 10) declare several objects of Customer
            Customer c1 = new Customer("c1");
            Customer c2 = new Customer("c2");
            // 11) subscribe method GotNewGoods() of every Customer instance 
            // to event NewGoodsInfo of object of OnlineShop
            on.NewGoodsInfo += c1.GotNewGoods;
            on.NewGoodsInfo += c2.GotNewGoods;
            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results
            on.NewGoods("dfdff");
            Console.ReadKey();
        }
    }
}
