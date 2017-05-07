using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CRUD_v2
{
    public partial class BuilderForm : Form
    {
        public BuilderForm()
        {
            InitializeComponent();
            // Запускаем поток с консолью.
            Task.Factory.StartNew(Console);
        }


        private void Console()
        {
            // Запускаем консоль.
            if (AllocConsole())
            {
                System.Console.WriteLine("Для выхода наберите exit.");
                System.Console.WriteLine("Для показа результата выполнения шаблона Builder нажмите любую клавишу");
                while (true)
                {
                    // Считываем данные.
                    string output = System.Console.ReadLine();
                    if (output == "exit")
                        break;
                    // Выводим данные в textBox
                    Action action = () => richTextBox1.Text += output + Environment.NewLine;
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();

                    // Create director and builders
                    Director director = new Director();

                    Builder b1 = new ConcreteBuilder1();
                    Builder b2 = new ConcreteBuilder2();

                    // Construct two products
                    director.Construct(b1);
                    Product p1 = b1.GetResult();
                    p1.Show();

                    director.Construct(b2);
                    Product p2 = b2.GetResult();
                    p2.Show();
                }

               

                //// Wait for user
                //Console.ReadKey();















                // Закрываем консоль.
                FreeConsole();
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();



      
    }

    
}

          