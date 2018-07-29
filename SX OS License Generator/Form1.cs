using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SX_OS_License_Generator
{
    public partial class Form1 : Form
    {
        static generator gen = new generator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Connecting to Team Xecuter servers");
                gen.wait(500);
                Console.Clear();
                Console.WriteLine("Connecting to Team Xecuter servers.");
                gen.wait(500);
                Console.Clear();
                Console.WriteLine("Connecting to Team Xecuter servers..");
                gen.wait(500);
                Console.Clear();
                Console.WriteLine("Connecting to Team Xecuter servers...");
                gen.wait(500);
                Console.Clear();
            }
            Console.WriteLine("Connecting to Team Xecuter servers...");
            Console.WriteLine("Connected");
            gen.wait(1000);
            Console.WriteLine("Generating Ticket");
            gen.wait(1000);
            Console.WriteLine("Gathering Console Info");
            gen.wait(2000);
            Console.WriteLine("Code Generated!");
            textBox1.Text = gen.getCode();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            browser form = new browser();
            form.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            info form = new info();
            form.ShowDialog();
            this.Show();
        }
    }
}
