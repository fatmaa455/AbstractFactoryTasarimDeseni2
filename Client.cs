using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory3
{
    class Client
    {
        ICommand command;
        IConnection connection;

        public Client(DBFactory dB)
        {
            command = dB.CreateCommand();
            connection = dB.CreateConnection();
        }

        public void calistir()
        {
            command.command();
            connection.conneciton();
        }
    }
}
