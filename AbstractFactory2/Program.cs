using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{

    public interface Iconnetcion
    {
        void connect();
        void disconnect();
    }

    public class MSSqlConnection : Iconnetcion
    {
        public void connect()
        {
            Console.WriteLine("MSSQL Bağlantısı kuruldu");
        }

        public void disconnect()
        {
            Console.WriteLine("MSSQL Bağlantısı kapandı.");
        }
    }

    public class OracleConnection : Iconnetcion
    {
        public void connect()
        {
            Console.WriteLine("ORACLE Bağlantısı kuruldu");

        }

        public void disconnect()
        {
            Console.WriteLine("ORACLE Bağlantısı kapandı.");

        }
    }

    public interface Icommand
    {
        void Execute();
    }

    public class MSSqlCommand : Icommand
    {
        public void Execute()
        {
            Console.WriteLine("Mssql execute");

        }
    }

    public class OracleCommand : Icommand
    {
        public void Execute()
        {
            Console.WriteLine("Oracle execute");

        }
    }

    public abstract class DatabaseFactory
    {
        public abstract Iconnetcion CreateConnection();
        public abstract Icommand CreateCommand();
    }
    public class MSSQLFactory : DatabaseFactory
    {
        public override Icommand CreateCommand()
        {
            return new MSSqlCommand();
        }

        public override Iconnetcion CreateConnection()
        {
            return new MSSqlConnection();
        }
    }

    public class OracleFactort : DatabaseFactory
    {
        public override Icommand CreateCommand()
        {
            return new OracleCommand();
        }

        public override Iconnetcion CreateConnection()
        {
            return new OracleConnection();
        }
    }

    public class ApplicationClass
    {
        private DatabaseFactory _databaseFactory;
        private Iconnetcion _connection;
        private Icommand _command;

        public ApplicationClass(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = databaseFactory.CreateConnection();
            _command = databaseFactory.CreateCommand();
        }

        public void Connect()
        {
            _connection.connect();
        }
        public void Disconnect()
        {
            _connection.disconnect();
        }
        public void Command()
        {
            _command.Execute();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            ApplicationClass mssql = new ApplicationClass(new MSSQLFactory());
            mssql.Connect();
            mssql.Command();
            mssql.Disconnect();


            ApplicationClass oracle = new ApplicationClass(new OracleFactort());
            oracle.Connect();
            oracle.Command();
            oracle.Disconnect();

            Console.ReadLine();
        }
    }
}
