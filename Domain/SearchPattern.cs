using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlClient;
/*
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
    public class SearchPattern
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

        //  Вывод в Combobox cmbPatterns
        public override string ToString()
        {
            return RegularExpression + " | " + CompareWith + " | " + Action;
        }

    }
}
