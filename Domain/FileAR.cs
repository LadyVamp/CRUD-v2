using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlClient;

//Класс File содержит поля таблицы и методы для выборки по одному и нескольким форматам
namespace Domain
{
    public class FileAR
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

        public FileAR(int id, string name, string keywords, int size, string format, string content)
        {
            ID = id;
            Name = name;
            Keywords = keywords;
            Size = size;
            Format = format;
            Content = content;
        }

        public FileAR() //конструктор с 0 аргументов
        {
            ID = id;
            Name = name;
            Keywords = keywords;
            Size = size;
            Format = format;
            Content = content;
        }

    }
}

