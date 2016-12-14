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

        private const string CONNECTION_STRING =
    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC";

        //Insert
        public void Insert(SearchPattern arsp)  
        {
            using (SqlConnection connection1 = new SqlConnection(CONNECTION_STRING))
            {
                connection1.Open();

                using (SqlCommand command = connection1.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT INTO TSearchPattern (regularExpression, compareWith, action) VALUES('" + arsp.RegularExpression + "', '" + arsp.CompareWith + "', '" + arsp.Action + "')";
                    //command1.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }

        }

        //FillCombobox
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
        public void Update(SearchPattern oldPattern, SearchPattern newPattern)  
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE [TSearchPattern] SET regularExpression= '" + newPattern.RegularExpression + "', compareWith= '" + newPattern.CompareWith + "', action= '" + newPattern.Action + "' WHERE ID=" + oldPattern.ID;
                    //command.Parameters.AddWithValue("@ID", ID);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete
        public void Delete(SearchPattern sp)     
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



        public List<File> SelectByFormat(string format)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT ID, name, keywords, size, format, content FROM TFile WHERE Format = @Format";
            command.Parameters.AddWithValue("@Format", format);
            return GetFiles(connection, command);
        }

        public List<File> SelectByFormat(params string[] formats)
        {
            var sbNames = new StringBuilder(10 * formats.Length);
            for (int i = 0; i < formats.Length; i++)
            {
                string name = "@Format" + i;
                command.Parameters.Add(name, formats[i]);

                if (sbNames.Length > 0) sbNames.Append(",");
                sbNames.Append(name);
            }

            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT ID, name, keywords, size, format, content FROM TFile WHERE Format IN (" + sbNames.ToString() + ")";
            return GetFiles(connection, command);


        }

        private static List<File> GetFiles(OleDbConnection connection, OleDbCommand command)
        {
            List<File> fList = new List<File>();
            try
            {
                connection.Open();
                using (var reader = command.ExecuteReader())

                {
                    while (reader.Read())
                    {
                        File f = new File();
                        f.ID = Convert.ToInt32(reader["ID"].ToString());
                        f.Name = reader["name"].ToString();
                        f.Keywords = reader["keywords"].ToString();
                        f.Size = Convert.ToInt32(reader["size"].ToString());
                        f.Format = reader["format"].ToString();
                        f.Content = reader["content"].ToString();
                        fList.Add(f);
                    }
                    return fList;
                }
            }

            finally
            {
                if (connection != null) { connection.Close(); }
            }
        }

        public List<File> SelectDoc()
        {
            return SelectByFormat("doc");
        }

        public List<File> SelectDocx()
        {
            return SelectByFormat("docx");
        }

        public List<File> SelectTxt()
        {
            return SelectByFormat("txt");
        }

        public List<File> SelectDocAndDocx()
        {
            return SelectByFormat("doc", "docx");
        }

        public List<File> SelectDocAndTxt()
        {
            return SelectByFormat("doc", "txt");
        }

        public List<File> SelectDocxAndTxt()
        {
            return SelectByFormat("docx", "txt");
        }

        public List<File> SelectDocAndDocxAndTxt()
        {
            return SelectByFormat("doc", "docx", "txt");
        }


        ////SelectDoc
        //public List<File> SelectDoc()
        //{
        //    List<File> fList = new List<File>();

        //    try
        //    {
        //        command.CommandText = "SELECT * FROM TFile WHERE Format = 'doc'";
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();

        //        OleDbDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            File f = new File();
        //            f.ID = Convert.ToInt32(reader["ID"].ToString());
        //            f.Name = reader["name"].ToString();
        //            f.Keywords = reader["keywords"].ToString();
        //            f.Size = Convert.ToInt32(reader["size"].ToString());
        //            f.Format = reader["format"].ToString();
        //            f.Content = reader["content"].ToString();
        //            fList.Add(f);
        //        }
        //        return fList;

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

        ////SelectDocx
        //public List<File> SelectDocx()
        //{
        //    List<File> fList = new List<File>();
        //    try
        //    {
        //        command.CommandText = "SELECT * FROM TFile WHERE Format = 'docx'";
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();
        //        OleDbDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            File f = new File();
        //            f.ID = Convert.ToInt32(reader["ID"].ToString());
        //            f.Name = reader["name"].ToString();
        //            f.Keywords = reader["keywords"].ToString();
        //            f.Size = Convert.ToInt32(reader["size"].ToString());
        //            f.Format = reader["format"].ToString();
        //            f.Content = reader["content"].ToString();
        //            fList.Add(f);
        //        }
        //        return fList;
        //    }
        //    catch (Exception)
        //    { throw; }
        //    finally
        //    { if (connection != null) { connection.Close(); } }
        //}

        ////SelectTxt
        //public List<File> SelectTxt()
        //{
        //    List<File> fList = new List<File>();
        //    try
        //    {
        //        command.CommandText = "SELECT * FROM TFile WHERE Format = 'txt'";
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();
        //        OleDbDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            File f = new File();
        //            f.ID = Convert.ToInt32(reader["ID"].ToString());
        //            f.Name = reader["name"].ToString();
        //            f.Keywords = reader["keywords"].ToString();
        //            f.Size = Convert.ToInt32(reader["size"].ToString());
        //            f.Format = reader["format"].ToString();
        //            f.Content = reader["content"].ToString();
        //            fList.Add(f);
        //        }
        //        return fList;
        //    }
        //    catch (Exception)
        //    { throw; }
        //    finally
        //    { if (connection != null) { connection.Close(); } }
        //}

        ////SelectDocAndDocx
        //public List<File> SelectDocAndDocx()
        //{
        //    List<File> fList = new List<File>();

        //    try
        //    {
        //        command.CommandText = "SELECT * FROM TFile WHERE Format IN ('doc', 'docx')";
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();
        //        OleDbDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            File f = new File();
        //            f.ID = Convert.ToInt32(reader["ID"].ToString());
        //            f.Name = reader["name"].ToString();
        //            f.Keywords = reader["keywords"].ToString();
        //            f.Size = Convert.ToInt32(reader["size"].ToString());
        //            f.Format = reader["format"].ToString();
        //            f.Content = reader["content"].ToString();
        //            fList.Add(f);
        //        }
        //        return fList;

        //    }
        //    catch (Exception)
        //    { throw; }
        //    finally
        //    { if (connection != null) { connection.Close(); } }
        //}

        ////SelectDocAndTxt
        //public List<File> SelectDocAndTxt()
        //{
        //    List<File> fList = new List<File>();
        //    try
        //    {
        //        command.CommandText = "SELECT * FROM TFile WHERE Format IN ('doc', 'txt')";
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();
        //        OleDbDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            File f = new File();
        //            f.ID = Convert.ToInt32(reader["ID"].ToString());
        //            f.Name = reader["name"].ToString();
        //            f.Keywords = reader["keywords"].ToString();
        //            f.Size = Convert.ToInt32(reader["size"].ToString());
        //            f.Format = reader["format"].ToString();
        //            f.Content = reader["content"].ToString();
        //            fList.Add(f);
        //        }
        //        return fList;

        //    }
        //    catch (Exception)
        //    { throw; }
        //    finally
        //    { if (connection != null) { connection.Close(); } }
        //}

        ////SelectDocAndTxt
        //public List<File> SelectDocxAndTxt()
        //{
        //    List<File> fList = new List<File>();
        //    try
        //    {
        //        command.CommandText = "SELECT * FROM TFile WHERE Format IN ('docx', 'txt')";
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();
        //        OleDbDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            File f = new File();
        //            f.ID = Convert.ToInt32(reader["ID"].ToString());
        //            f.Name = reader["name"].ToString();
        //            f.Keywords = reader["keywords"].ToString();
        //            f.Size = Convert.ToInt32(reader["size"].ToString());
        //            f.Format = reader["format"].ToString();
        //            f.Content = reader["content"].ToString();
        //            fList.Add(f);
        //        }
        //        return fList;

        //    }
        //    catch (Exception)
        //    { throw; }
        //    finally
        //    { if (connection != null) { connection.Close(); } }
        //}


        ////SelectDocAndDocxAndTxt
        //public List<File> SelectDocAndDocxAndTxt()
        //{
        //    List<File> fList = new List<File>();
        //    try
        //    {
        //        command.CommandText = "SELECT * FROM TFile WHERE Format IN ('doc', 'docx', 'txt')";
        //        command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();
        //        OleDbDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            File f = new File();
        //            f.ID = Convert.ToInt32(reader["ID"].ToString());
        //            f.Name = reader["name"].ToString();
        //            f.Keywords = reader["keywords"].ToString();
        //            f.Size = Convert.ToInt32(reader["size"].ToString());
        //            f.Format = reader["format"].ToString();
        //            f.Content = reader["content"].ToString();
        //            fList.Add(f);
        //        }
        //        return fList;
        //    }
        //    catch (Exception)
        //    { throw; }
        //    finally
        //    { if (connection != null) { connection.Close(); } }
        //}

    }

    
}
