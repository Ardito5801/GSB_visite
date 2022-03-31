using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBFrais.Model.Business;

namespace GSBFrais.Model
{
    public class Dbal
    {
        private MySqlConnection connection;
        public Dbal (string database, string uid = "root", string password = "root", string server = "localhost")
        {
            Initialize(database, uid, password, server);
        }
        private void Initialize(string database, string uid, string password, string server)
        {
            string connectionString;
            connectionString = "SERVER= " + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        private void CUDQuery(string query)
        {
            if(this.OpenConnection() == true)
            {
                //créé la commande et assigne la query et la connexion depuis le constructeur
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute la commande
                cmd.ExecuteNonQuery();

                //ferme la commande
                this.CloseConnection();
            }
        }
        public void Insert(string query)
        {
            query = "INSERT INTO " + query;

            CUDQuery(query);
        }
        public void Update(string query)
        {
            query = "UPDATE " + query;
            CUDQuery(query);
        }
        public void Delete(string query)
        {
            query = "DELETE FROM " + query;

            CUDQuery(query);
        }
        private DataSet RQuery(string query)
        {
            DataSet dataset = new DataSet();
            if(this.OpenConnection() == true)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dataset);
                CloseConnection();
            }
            return dataset;
        }
        public DataTable SelectAll(string table)
        {
            string query = "SELECT * FROM " + table;
            DataSet dataset = RQuery(query);

            return dataset.Tables[0];
        }
        public DataRow SelectById(string table, string id)
        {
            string query = "SELECT * FROM " + table + " where id='" + id + "'";
            DataSet dataset = RQuery(query);

            return dataset.Tables[0].Rows[0];
        }

        public DataTable SelectByComposedFK2(string table, string keyName1, string keyValue1, string keyName2, string keyValue2)
        {
            string query = "SELECT * FROM " + table + " where " + keyName1 + " = " + keyValue1 + " AND "+ keyName2 + " = " + keyValue2;
            DataSet dataset = RQuery(query);

            return dataset.Tables[0];
        }

        public DataTable SelectByField(string table, string fieldTestCondition)
        {
            string query = "SELECT * FROM " + table + " where " + fieldTestCondition;
            DataSet dataset = RQuery(query);

            return dataset.Tables[0];
        }

        
    }
}
