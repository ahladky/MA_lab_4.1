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
            on.NewGoods("dfdff");
            // 10) declare several objects of Customer
            Customer c1 = new Customer("c1");
            Customer c2 = new Customer("c2");
            Customer c3 = new Customer("c3");
            // 11) subscribe method GotNewGoods() of every Customer instance 
            // to event NewGoodsInfo of object of OnlineShop
          
            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results

        }
    }
}
