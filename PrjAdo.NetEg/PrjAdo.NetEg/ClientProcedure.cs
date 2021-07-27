using System;
using System.Collections.Generic;
using System.Text;

namespace PrjAdo.NetEg
{
    class ClientProcedure
    {
        static void Main()
        {
            DataAccessLayer spobject = new DataAccessLayer();
            // spobject.CallTenMostExpensiveProduct();

            Console.WriteLine("Enter the CustomerId");
            string cid = Console.ReadLine();
            spobject.CallCustOrdersOrders(cid);

        }
    }
}
