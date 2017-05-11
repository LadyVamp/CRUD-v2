using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_v2
{
    //Шаблон GOF Строитель
    //Вызов в MainAP.cs

    /// The 'Director' class
    class Director
    {
        // Builder uses a complex series of steps
        public void Construct(Builder builder)
        {
            //builder.BuildPartA();
            //builder.BuildPartB();
            builder.BuildCompare();
            builder.BuildAction();
        }
    }

    /// The 'Builder' abstract class
    abstract class Builder
    {
        public abstract void BuildCompare();
        public abstract void BuildAction();
        public abstract Product GetResult();
    }

    /// The 'ConcreteBuilder1' class
    class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public override void BuildCompare()
        {
            //_product.Add("PartA");
            _product.Add("Имя файла");
        }

        public override void BuildAction()
        {
            //_product.Add("PartB");
            _product.Add("Включить");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    /// The 'ConcreteBuilder2' class
    class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();

        public override void BuildCompare()
        {
            //_product.Add("PartX");
            _product.Add("Абсолютный путь");
        }

        public override void BuildAction()
        {
            _product.Add("Исключить");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    /// The 'ConcreteBuilder3' class
    class ConcreteBuilder3 : Builder
    {
        private Product _product = new Product();

        public override void BuildCompare()
        {
            _product.Add("Имя файла");
        }

        public override void BuildAction()
        {
            _product.Add("Исключить");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    /// The 'ConcreteBuilder4' class
    class ConcreteBuilder4 : Builder
    {
        private Product _product = new Product();

        public override void BuildCompare()
        {
            _product.Add("Абсолютный путь");
        }

        public override void BuildAction()
        {
            _product.Add("Включить");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    /// The 'Product' class
    class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nЧасти шаблона поиска -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }


}
