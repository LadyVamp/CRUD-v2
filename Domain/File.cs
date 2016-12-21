﻿using System;
using System.Collections.Generic;
//using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlClient;

//Класс File содержит поля таблицы и методы для выборки по одному и нескольким форматам
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

         public File() //конструктор с 0 аргументов
         {
             ID = id;
             Name = name;
             Keywords = keywords;
             Size = size;
             Format = format;
             Content = content;
         }


        /* Весь код ниже уже есть в Broker.cs и выполняется там */
    //     //  Соединение с БД
    //     SqlConnection con;
    //     SqlCommand cmd;
    //     private void ConnectTo1()
    //     {
    //         con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SearchBase;Data Source=NADYA-PC");
    //         cmd = con.CreateCommand();
    //     }
    //     //  /Соединение с БД


    //     //  Универсальные методы для выборки по одному и нескольким форматам
    //    public List<File> SelectByFormat(string format)
    //    {
    //        cmd.CommandType = System.Data.CommandType.Text;
    //        cmd.CommandText = "SELECT ID, name, keywords, size, format, content FROM TFile WHERE Format = @Format";
    //        cmd.Parameters.Clear();
    //        cmd.Parameters.AddWithValue("@Format", format);
    //        return GetFiles(con, cmd);
    //    }

    //    public List<File> SelectByFormat(params string[] formats)
    //    {
    //        var sbNames = new StringBuilder(10 * formats.Length);
    //        cmd.Parameters.Clear();  //вызов перед циклом
    //        for (int i = 0; i < formats.Length; i++)
    //        {
    //            string name = "@Format" + i;
    //            cmd.Parameters.AddWithValue(name, formats[i]);
                
    //            if (sbNames.Length > 0) sbNames.Append(",");
    //            sbNames.Append(name);
    //        }

    //        cmd.CommandType = System.Data.CommandType.Text;
    //        cmd.CommandText = "SELECT ID, name, keywords, size, format, content FROM TFile WHERE Format IN (" + sbNames.ToString() + ")";
    //        return GetFiles(con, cmd);
    //    }

    //    private static List<File> GetFiles(SqlConnection con, SqlCommand cmd)
    //    {
    //        List<File> fList = new List<File>();
    //        try
    //        {
    //            con.Open();
    //            using (var reader1 = cmd.ExecuteReader())
    //            {
    //                while (reader1.Read())
    //                {
    //                    File f = new File();
    //                    f.ID = Convert.ToInt32(reader1["ID"].ToString());
    //                    f.Name = reader1["name"].ToString();
    //                    f.Keywords = reader1["keywords"].ToString();
    //                    f.Size = Convert.ToInt32(reader1["size"].ToString());
    //                    f.Format = reader1["format"].ToString();
    //                    f.Content = reader1["content"].ToString();
    //                    fList.Add(f);
    //                }
    //                return fList;
    //            }
    //        }

    //        finally
    //        {
    //            if (con != null) { con.Close(); }
    //        }
    //    }
        

    //    //Применение методов
    //    public List<File> SelectDoc()
    //    {
    //        return SelectByFormat("doc");
    //    }

    //    public List<File> SelectDocx()
    //    {
    //        return SelectByFormat("docx");
    //    }

    //    public List<File> SelectTxt()
    //    {
    //        return SelectByFormat("txt");
    //    }

    //    public List<File> SelectRtf()
    //    {
    //        return SelectByFormat("rtf");
    //    }

    //    public List<File> SelectDocAndDocx()
    //    {
    //        return SelectByFormat("doc", "docx");
    //    }

    //    public List<File> SelectDocAndTxt()
    //    {
    //        return SelectByFormat("doc", "txt");
    //    }

    //    public List<File> SelectDocxAndTxt()
    //    {
    //        return SelectByFormat("docx", "txt");
    //    }

    //    public List<File> SelectDocAndDocxAndTxt()
    //    {
    //        return SelectByFormat("doc", "docx", "txt");
    //    }

    //    public List<File> SelectDocAndDocxAndTxtAndRtf()
    //    {
    //        return SelectByFormat("doc", "docx", "txt", "rtf");
    //    }

    //}

    }
}
