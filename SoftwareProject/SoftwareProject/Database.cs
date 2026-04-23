using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace SoftwareProject
{
    class Database
    {
        //public const string connectionString = "Data Source = localhost/orcl; User Id = C##user1; Password = REDACTED";
        public const string connectionString = "Data Source = studentoracle/orcl; User Id = T00257714; Password = ttn97vy?dKhi";

        public static OracleConnection OpenConnection()

        {

            OracleConnection conn = new OracleConnection(Database.connectionString);

            conn.Open();

            return conn;

        }

        public static DataSet ExecuteMultiRowQuery(string query)
        {

            OracleConnection conn = OpenConnection();

            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            conn.Close();

            return ds;


        }

        public static int ExecuteUpdateStatement(string query)
        {
            OracleConnection conn = null;

            try
            {
                conn = OpenConnection();

                OracleTransaction transaction;
                transaction = conn.BeginTransaction();
                OracleCommand cmd = new OracleCommand(query, conn);

                int rowsAffected = cmd.ExecuteNonQuery();
                transaction.Commit();
                return rowsAffected;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void ExecuteNonQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();
            OracleTransaction transaction;
            transaction = conn.BeginTransaction();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Execute the DB non-query
            cmd.ExecuteNonQuery();
            transaction.Commit();

            //Close the DB connection
            conn.Close();

        }

        public static OracleDataReader ExecuteSingleRowQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Execute the query and atore the results in an OracleDataReader
            OracleDataReader dr = cmd.ExecuteReader();

            return dr;

        }
    }
}
