using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int result;
            result = stack.push(textBox1.Text);
            if (result == 1)
                MessageBox.Show("Item added is (" + ")");
            else
                MessageBox.Show("You can't add a empty value!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string top;
            top = stack.top();

            if (top != null)
                MessageBox.Show("The top is " + top);
            else
                MessageBox.Show("Your Stack is empty.");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string pop;
            pop = stack.pop();
            if (pop != null)
            {
                MessageBox.Show("Item removed is (" + pop + ")");
            }
            else
                MessageBox.Show("Your Stack is Empty.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
