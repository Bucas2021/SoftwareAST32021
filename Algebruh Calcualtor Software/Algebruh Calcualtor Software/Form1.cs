using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mathematical.Expressions;

namespace Algebruh_Calcualtor_Software
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

 

        private void OnKeyDownHandler(object sender, EventArgs e)
        {

        }
        
        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<MyMath> list = new List<MyMath>();
            list.Add(new MyMath() { a = 2.1, b = 3, c = 4.5 });
            list.Add(new MyMath() { a = 3.5, b = 2, c = 3.5 });
            list.Add(new MyMath() { a = 3.2, b = 1, c = 1.5 });
            dataGridView1.DataSource = list;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<MyMath> list = dataGridView1.DataSource as List<MyMath>;
            if (list != null)
            {
                foreach(MyMath math in list)
                {
                    ExpressionEval eval = new ExpressionEval(math.formula);
                    eval.SetVariable("a", math.a);
                    eval.SetVariable("b", math.b);
                    eval.SetVariable("c", math.c);
                    math.result = (double)eval.Evaluate();
                }
                dataGridView1.DataSource = list;
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
