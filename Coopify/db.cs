using MySql.Data.MySqlClient;
namespace Coopify
{
    public class DBConnect
    {
        private readonly MySqlConnection connection;
        private string server = "";
        private string database = "";
        private string uid = "";
        private string password = "";

        //Constructor
        public DBConnect()
        {
            try
            {
                connection = Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Initialize values
        private MySqlConnection Initialize()
        {
            server = "localhost";
            database = "coopify";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            return new(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database Connected");
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string table, string columns, string values)
        {
            string query = "insert into "+table+" ("+ columns + ") " + "values ("+ values + ");";

            //open connection
            if (OpenConnection())
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        //Update statement
        public void Update(string table, string set, string where)
        {
            string query = "UPDATE " + table + " SET "+ set + " WHERE " + where;

            //Open connection
            if (OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string table, string where)
        {
            string query = "DELETE FROM " + table + " WHERE " + where;

            if (OpenConnection())
            {
                MySqlCommand cmd = new(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select(string query, string[] labels)
        {
            List<string>[] list = new List<string>[labels.Length];

            for (int x = 0; x < labels.Length; x++)
                list[x] = new List<string>();

            //Open connection
            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int x = 0; x < labels.Length; x++)
                    {
                        if (dataReader.HasRows)
                        {
                            list[x].Add(dataReader.GetString(x));
                            //MessageBox.Show(dataReader.GetString(x));
                        }

                    }
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed

                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count(string table)
        {
            string query = "SELECT Count(*) FROM " + table;
            int Count = -1;

            //Open Connection
            if (OpenConnection())
            {
                //Create Mysql Command
                MySqlCommand cmd = new(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
