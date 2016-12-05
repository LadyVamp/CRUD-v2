using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Session
{
    public class Broker
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC");
            command = connection.CreateCommand();
        }

        public Broker()
        {
            ConnectTo();
        }

        public void Insert(SearchPattern sp)
        {
            try
            {
                command.CommandText = "INSERT INTO TSearchPattern (regularExpression, compareWith, action) VALUES('" + sp.RegularExpression + "', '" + sp.CompareWith + "', '" + sp.Action + "')";
                
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
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

        public List<SearchPattern> FillCombobox()
        {
            List<SearchPattern> spList = new List<SearchPattern>();

            try
            {
                command.CommandText = "SELECT * FROM TSearchPattern";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    SearchPattern sp = new SearchPattern();

                    sp.Id = Convert.ToInt32(reader["ID"].ToString());
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

        public void Update(SearchPattern oldPattern, SearchPattern newPattern)
        {

            try
            {
                command.CommandText = "UPDATE TSearchPattern SET regularExpression= '" + newPattern.RegularExpression + "', compareWith= '" + newPattern.CompareWith + "', action= '" + newPattern.Action + "' WHERE ID=" + oldPattern.Id;
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
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

        public void Delete(SearchPattern sp)
        {
            try
            {
                command.CommandText = "DELETE FROM TSearchPattern WHERE ID= " + sp.Id;
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
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

    }

    
}
