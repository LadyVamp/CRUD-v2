using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlClient;

namespace Session
{
    public class SearchPattern
    {
        //  CRUD поисковых шаблонов
        // Соединение с БД
        SqlConnection connection;
        SqlCommand command;

        private void ConnectTo()
        {
            connection = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC");
            command = connection.CreateCommand();
        }

        private const string CONNECTION_STRING =
    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC";
        //  /CRUD поисковых шаблонов

        public SearchPattern()
        {
            ConnectTo();
        }


        //  CRUD поисковых шаблонов
        //Create
        public void Create(SearchPatternAR arsp)
        {
            using (SqlConnection connection1 = new SqlConnection(CONNECTION_STRING))
            {
                connection1.Open();

                using (SqlCommand command = connection1.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT INTO TSearchPattern (regularExpression, compareWith, action) VALUES('" + arsp.RegularExpression + "', '" + arsp.CompareWith + "', '" + arsp.Action + "')";
                    command.ExecuteNonQuery();
                }
            }

        }

        //Read
        public List<SearchPatternAR> Read()   
        {
            List<SearchPatternAR> spList = new List<SearchPatternAR>();

            try
            {
                command.CommandText = "SELECT * FROM TSearchPattern";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    SearchPatternAR sp = new SearchPatternAR();

                    sp.ID = Convert.ToInt32(reader["ID"].ToString());
                    sp.RegularExpression = reader["regularExpression"].ToString();
                    sp.CompareWith = reader["compareWith"].ToString();
                    sp.Action = reader["action"].ToString();

                    spList.Add(sp);
                }
                return spList;

            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        //Update
        public void Update(SearchPatternAR oldPattern, SearchPatternAR newPattern)  
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE [TSearchPattern] SET regularExpression= '" + newPattern.RegularExpression + "', compareWith= '" + newPattern.CompareWith + "', action= '" + newPattern.Action + "' WHERE ID=" + oldPattern.ID;

                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete
        public void Delete(SearchPatternAR sp)     
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "DELETE FROM TSearchPattern WHERE ID= " + sp.ID;
                    command.ExecuteNonQuery();
                }
            }
        }
        //  /CRUD поисковых шаблонов


    }

    
}
