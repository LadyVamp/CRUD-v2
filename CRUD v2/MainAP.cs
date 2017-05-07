using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //для консоли

namespace CRUD_v2
{
    public partial class MainAP : Form
    {
        public MainAP(string role)
        {
            InitializeComponent();
            lblRole.Text = role;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSP f = new AdminSP();
            f.Show();
        }

        private void btnOpenBuilder_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(Console);
        }

        private void Console()
        {
            // Запускаем консоль
            if (AllocConsole())
            {
                System.Console.WriteLine("Для показа результата выполнения шаблона Builder нажмите Enter");
                System.Console.WriteLine("Для выхода наберите exit.");
                while (true)
                {
                    // Считываем данные
                    string output = System.Console.ReadLine();
                    if (output == "exit")
                        break;
                    /*
                    // Раскомментить при появлении текстбокса!
                    //Выводим данные в textBox
                    //Action action = () => richTextBox1.Text += output + Environment.NewLine;
                    //if (InvokeRequired)
                    //    Invoke(action);
                    //else
                    //    action();
                    */

                    // Create director and builders
                    Director director = new Director();

                    Builder b1 = new ConcreteBuilder1();
                    Builder b2 = new ConcreteBuilder2();
                    Builder b3 = new ConcreteBuilder3();
                    Builder b4 = new ConcreteBuilder4();

                    // Construct 4 products
                    director.Construct(b1);
                    Product p1 = b1.GetResult();
                    p1.Show();

                    director.Construct(b2);
                    Product p2 = b2.GetResult();
                    p2.Show();

                    director.Construct(b3);
                    Product p3 = b3.GetResult();
                    p3.Show();

                    director.Construct(b4);
                    Product p4 = b4.GetResult();
                    p4.Show();
                }

                // Закрываем консоль
                FreeConsole();
            }
        }

        //для консоли
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

    }
}
