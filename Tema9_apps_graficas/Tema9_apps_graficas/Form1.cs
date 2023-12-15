using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema9_apps_graficas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hola");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
        } 
        
        public void Main(object sender, EventArgs e)
        {
            Console.WriteLine(richTextBox1);
        }
    }
}
