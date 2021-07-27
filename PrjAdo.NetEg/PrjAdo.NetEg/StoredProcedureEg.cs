using System;
using System.Data.SqlClient;
using System.Data;

namespace PrjAdo.NetEg
{

    class DataAccessLayer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection GetConnection()
        {
            con = new SqlConnection(
                 "Data Source = DESKTOP-U8J1M3C\\MSSQLSERVER01; Initial Catalog = Northwind; Integrated Security = true");
            con.Open();
            return con;
        }

        //CProcedurewithoutParameter
      internal  void CallTenMostExpensiveProduct()
        {
            try {

                con = GetConnection();
                //Procedure name in sqlserver  
                cmd = new SqlCommand("Ten Most Expensive Products", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "  " + dr[1]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }


        internal void CallCustOrdersOrders(string cid)
        {
            try
            {
                con = GetConnection();
                cmd = new SqlCommand("CustOrdersOrders", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", cid);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if(dr["OrderID"]!=null)
                        {
                        Console.WriteLine(dr["OrderID"] + "  " + dr["OrderDate"] + "  " + dr["ShippedDate"]);
                    }
                  
                }
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                con.Close();
            }
        }
    }
    class StoredProcedureEg
    {
        /*
       static void Main()
       {
         DataAccessLayer spobject = new DataAccessLayer();
          // spobject.CallTenMostExpensiveProduct();

           Console.WriteLine("Enter the CustomerId");
           string cid = Console.ReadLine();
           spobject.CallCustOrdersOrders(cid);

       }*/
    }
}
