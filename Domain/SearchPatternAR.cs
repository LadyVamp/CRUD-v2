using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlClient;
/*
 * Этот файл декоративный, строка подключения старая, но ошибок нет. Оставим его для истории :)
 * Шаблон Active Record охватывает и данные и поведение. Большая часть его данных является постоянной 
 * и должна храниться в базе данных. В типовом решении активная запись используется наиболее очевидный
 * подход, при котором логика доступа к данным включается в объект домена. 
 * Класс SearchPattern содержит поля таблицы и методы CRUD.
 * 
 * В основе типового решения активная запись лежит модель предметной области (Domain Model), 
 * классы которой повторяют структуру записей используемой базы данных. Каждая активная запись отвечает
 * за сохранение и загрузку информации в БД, а так же за логику домена, применяемую к данным. 
 * Это может быть вся бизнес-логика приложения.
 */
namespace Domain
{
    public class SearchPatternAR
    {
       //Поля таблицы
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

        public SearchPatternAR(int id, string regularExpression, string compareWith, string action)
        {
            ID = id;
            RegularExpression = regularExpression;
            CompareWith = compareWith;
            Action = action;
        }

        public SearchPatternAR() //конструктор с 0 аргументов
        {
            ID = id;
            RegularExpression = regularExpression;
            CompareWith = compareWith;
            Action = action;
        }

        //  Вывод в Combobox cmbPatterns
        public override string ToString()
        {
            return RegularExpression + " | " + CompareWith + " | " + Action;
        }

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

        //Create
        public void Create()
        {
            using (SqlConnection connection1 = new SqlConnection(CONNECTION_STRING))
            {
                connection1.Open();

                using (SqlCommand command = connection1.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT INTO TSearchPattern (regularExpression, compareWith, action) VALUES('" + RegularExpression + "', '" + CompareWith + "', '" + Action + "')";
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
        public void Update()
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE [TSearchPattern] SET regularExpression= '" + RegularExpression + "', compareWith= '" + CompareWith + "', action= '" + Action + "' WHERE ID=" + ID;
                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete
        public void Delete()
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "DELETE FROM TSearchPattern WHERE ID= " + ID;
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
