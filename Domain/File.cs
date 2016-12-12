using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlClient;

namespace Domain
{
    public class File
    {
        int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string keywords;
        public string Keywords
        {
            get { return keywords; }
            set { keywords = value; }
        }

        int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        string format;
        public string Format
        {
            get { return format; }
            set { format = value; }
        }

        string content;
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

         public File(int id, string name, string keywords, int size, string format, string content)
        {
            ID = id;
            Name = name;
            Keywords = keywords;
            Size = size;
            Format = format;
            Content = content;
        }

         //Соединение с БД
         OleDbConnection connection;
         OleDbCommand command;
         private void ConnectTo()
         {
             connection = new OleDbConnection(@"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC");
             command = connection.CreateCommand();
         }

         private const string CONNECTION_STRING =
    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC";

        ////Поиск по ключевым словам, формату и размеру файла
        ////ввести в checkbox и textbox, вывести в datagridview
        // public void Search(File f)
        // {
        //     using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
        //     {
        //         con.Open();

        //         using (SqlCommand command = con.CreateCommand())
        //         {
        //             command.CommandType = System.Data.CommandType.Text;
        //             //command.CommandText = "INSERT INTO TSearchPattern (regularExpression, compareWith, action) VALUES('" + arsp.RegularExpression + "', '" + arsp.CompareWith + "', '" + arsp.Action + "')";
        //             //здесь сложный запрос
        //             //TODO. глянуть примеры https://www.youtube.com/results?search_query=datagridview+checkbox+c%23+
        //             //! пример для поиска по ключевым словам https://www.youtube.com/watch?v=ErrbRSXnxGM
        //             command.ExecuteNonQuery();
        //         }
        //     }

        // }

         //Поиск по ключевым словам
         public void SearchData(string valueToSearch)
         {
             using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
             {
                 con.Open();

                 using (SqlCommand command = con.CreateCommand())
                 {
                     command.CommandType = System.Data.CommandType.Text;
                     string query = "SELECT * FROM TFile WHERE CONCAT('Name', 'Keywords') LIKE '%"+valueToSearch+"%' ";
                     //dataGridView1.DataSource = 
                     //здесь сложный запрос
                     //TODO. глянуть примеры https://www.youtube.com/results?search_query=datagridview+checkbox+c%23+
                     //! пример для поиска по ключевым словам https://www.youtube.com/watch?v=ErrbRSXnxGM
                     // [G] фильтрация datagridview c#
                     command.ExecuteNonQuery();
                 }
             }

         }
    }
}
