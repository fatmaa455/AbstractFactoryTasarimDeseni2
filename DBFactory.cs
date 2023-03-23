using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory3
{
    interface DBFactory
    {
        ICommand CreateCommand();
        IConnection CreateConnection();
    }

    class SQLFactory : DBFactory
    {
        public ICommand CreateCommand()
        {
            return new SQLCommand();
        }

        public IConnection CreateConnection()
        {
            return new SQLConnection();
        }
    }

    class OracleFactory : DBFactory
    {
        public ICommand CreateCommand()
        {
            return new OracleCommand();
        }

        public IConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
