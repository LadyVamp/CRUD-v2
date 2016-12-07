﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlClient;

namespace Domain
{
    public class SearchPattern
    {
        int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        string regularExpression;
        public string RegularExpression
        {
            get { return regularExpression; }
            set { regularExpression = value; }
        }

        string compareWith;
        public string CompareWith
        {
            get { return compareWith; }
            set { compareWith = value; }
        }

        string action;
        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        public SearchPattern(int id, string regularExpression, string compareWith, string action)
        {
            ID = id;
            RegularExpression = regularExpression;
            CompareWith = compareWith;
            Action = action;
        }

        public SearchPattern() //конструктор с 0 аргументов
        {
            ID = id;
            RegularExpression = regularExpression;
            CompareWith = compareWith;
            Action = action;
        }

        public void PatternRecord() //Active Record
        {
            SearchPattern arsp = new SearchPattern();
            arsp.RegularExpression = "XYZ";
            arsp.CompareWith = "XYZ1";
            arsp.Action = "XYZ2";
            Insert(arsp);
        }
        


        //Вывод в Combobox cmbPatterns
        public override string ToString()
        {
            return RegularExpression + " | " + CompareWith + " | " + Action;
        }

        //Соединение с БД
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC");
            command = connection.CreateCommand();
        }

        //Методы CRUD
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


    }
}
