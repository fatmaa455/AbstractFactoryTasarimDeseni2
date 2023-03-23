using System;

namespace AbstractFactory3
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new SQLFactory());
            client.calistir();

            Client client1 = new Client(new OracleFactory());
            client1.calistir();
        }
    }
}
