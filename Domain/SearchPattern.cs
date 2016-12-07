using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

using System.Data;
using System.Data.SqlClient;

namespace Domain
{
    //public class SearchPattern
    //{
        //int id;
        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //string regularExpression;
        //public string RegularExpression
        //{
        //    get { return regularExpression; }
        //    set { regularExpression = value; }
        //}

        //string compareWith;
        //public string CompareWith
        //{
        //    get { return compareWith; }
        //    set { compareWith = value; }
        //}

        //string action;
        //public string Action
        //{
        //    get { return action; }
        //    set { action = value; }
        //}

        ////Вывод в Combobox cmbPatterns
        //public override string ToString()
        //{
        //    return RegularExpression + " | " + CompareWith + " | " + Action;
        //}

        ////Соединение с БД
        //OleDbConnection connection;
        //OleDbCommand command;

        //private void ConnectTo()
        //{
        //    connection = new OleDbConnection(@"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC");
        //    command = connection.CreateCommand();
        //}

        ////Методы CRUD
        //public void Insert(SearchPattern sp)
        //{
        //    try
        //    {
        //        command.CommandText = "INSERT INTO TSearchPattern (regularExpression, compareWith, action) VALUES('" + sp.RegularExpression + "', '" + sp.CompareWith + "', '" + sp.Action + "')";
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();

        //        command.ExecuteNonQuery();
        //    }

        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    finally
        //    {
        //        if (connection != null)
        //        {
        //            connection.Close();
        //        }
        //    }

        //}

        //public List<SearchPattern> FillCombobox()
        //{
        //    List<SearchPattern> spList = new List<SearchPattern>();

        //    try
        //    {
        //        command.CommandText = "SELECT * FROM TSearchPattern";
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();

        //        OleDbDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            SearchPattern sp = new SearchPattern();

        //            sp.Id = Convert.ToInt32(reader["ID"].ToString());
        //            sp.RegularExpression = reader["regularExpression"].ToString();
        //            sp.CompareWith = reader["compareWith"].ToString();
        //            sp.Action = reader["action"].ToString();

        //            spList.Add(sp);
        //        }
        //        return spList;

        //    }

        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    finally
        //    {
        //        if (connection != null)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        //public void Update(SearchPattern oldPattern, SearchPattern newPattern)
        //{
        //    try
        //    {
        //        command.CommandText = "UPDATE TSearchPattern SET regularExpression= '" + newPattern.RegularExpression + "', compareWith= '" + newPattern.CompareWith + "', action= '" + newPattern.Action + "' WHERE ID=" + oldPattern.Id;
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();

        //        command.ExecuteNonQuery();
        //    }

        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    finally
        //    {
        //        if (connection != null)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        //public void Delete(SearchPattern sp)
        //{
        //    try
        //    {
        //        command.CommandText = "DELETE FROM TSearchPattern WHERE ID= " + sp.Id;
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();

        //        command.ExecuteNonQuery();
        //    }

        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    finally
        //    {
        //        if (connection != null)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}


        ////active record
        //public static SearchPattern GetSearchPattern 
        //{ 
        //    get="SELECT * FROM TSearchPattern";
        //    SearchPattern rsp = new SearchPattern();
        //    return rsp;
        //}

        ////active record
        //SearchPattern rsp = new SearchPattern();
        //rsp.RegularExpression = "*\.doc";
        //rsp.CompareWith = "Имя файла";
        //rsp.Action = "Включить";

        public class SearchPattern
        {

            ////Соединение с БД
            //OleDbConnection connection;
            //OleDbCommand command;

            //private void ConnectTo()
            //{
            //    connection = new OleDbConnection(@"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC");
            //    command = connection.CreateCommand();
            //}

            //private const string CONNECTION_STRING =
            //    "Data Source=(local);Initial Catalog=DesignPatterns;Integrated Security=True";

            private const string CONNECTION_STRING =
    "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC";

            //public int ID { get; set; }
            //public string Name { get; set; }
            //public bool IsPremiumMember { get; set; }
            public int ID { get; set; }
            public string RegularExpression { get; set; }
            public string CompareWith { get; set; }
            public string Action { get; set; }
            

            public SearchPattern(int id, string regularExpression, string compareWith, string action)
            {
                //ID = id;
                //Name = name;
                //IsPremiumMember = isPremiumMember;
                ID = id;
                RegularExpression = regularExpression;
                CompareWith = compareWith;
                Action = action; 
            }

            // This static method acts like an object factory for Customer objects,
            // reading the values from the database and creating the object.
            //
            // So, the code to get a customer from the database might be:
            //
            //    Customer.GetByID(123);
            //
            public static SearchPattern GetByID(int id)
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.Text;

                        command.CommandText = "SELECT TOP 1 * FROM [TSeachPattern] WHERE [ID] = @ID";
                        command.Parameters.AddWithValue("@ID", id);

                        SqlDataReader reader = command.ExecuteReader();

                        // If the query returned a row, create the Customer object and return it.
                        if (reader.HasRows)
                        {
                            reader.Read();

                            //string name = (string)reader["Name"];
                            //bool isPremiumMember = (bool)reader["IsPremiumMember"];
                            string regularExpression = (string)reader["RegularExpression"];
                            string compareWith = (string)reader["CompareWith"];
                            string action = (string)reader["Action"];

                            return new SearchPattern(id, regularExpression, compareWith, action);
                        }
                    }
                }

                return null;
            }

            public void Save()
            {
                // This method needs to handle INSERT (new Customer) and UPDATE (existing Customer).
                // Or, you would need to create two separate functions, and call them when appropriate.

                // This function would not need to receive a parameter, with the Customer object.
                // It's inside the Customer object, so all the property values are already available to it.

                // Pretend there is code here to do the insert and/or update to the database.
            }


            public void Delete()
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.Text;

                        command.CommandText = "DELETE FROM [TSearchPattern] WHERE [ID] = @ID";
                        // This method uses the ID value from this object's property.
                        // This function didn't need to receive that value from a parameter.
                        command.Parameters.AddWithValue("@ID", ID);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

    }
//}
