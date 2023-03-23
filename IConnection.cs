using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory3
{
    interface IConnection
    {
        void conneciton();
    }

    public class SQLConnection : IConnection
    {
        public void conneciton()
        {
            Console.WriteLine("SQL Conneciton");
        }
    }
    public class OracleConnection : IConnection
    {
        public void conneciton()
        {
            Console.WriteLine("Oracle Conneciton");
        }
    }
}
