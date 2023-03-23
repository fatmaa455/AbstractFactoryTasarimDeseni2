using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory3
{
    interface ICommand
    {
        void command();
    }

    public class SQLCommand : ICommand
    {
        public void command()
        {
            Console.WriteLine("SQL command");
        }
    }
    public class OracleCommand : ICommand
    {
        public void command()
        {
            Console.WriteLine("Oracle command");
        }
    }
}
