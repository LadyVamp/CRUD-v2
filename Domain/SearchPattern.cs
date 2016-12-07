﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class SearchPattern
    {
        int id;
        public int Id
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


    }
}
