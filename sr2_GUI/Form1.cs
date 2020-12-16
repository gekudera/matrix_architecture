
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sr2_GUI
{
    public partial class Form1 : Form
    {
        Graphics b;
        IMatrix current_matrix;
        DrawInConsole cons;
        DrawInForm form;
        HorizontalGroupOfMatrix hor_gr;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Clear();
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);

            current_matrix = new SimpleMatrix(7, 6);
            InitiatorMatrix.RandomMatr(current_matrix, 40, 100);

            current_matrix.Draw(cons);
            current_matrix.Draw(form);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.Clear();
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);

            current_matrix.Draw(cons);
            current_matrix.Draw(form);

        }

        private void but_sparse_Click(object sender, EventArgs e)
        {
            Console.Clear();
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);

            current_matrix = new SparseMatrix(7, 7);
            InitiatorMatrix.RandomMatr(current_matrix, 10, 100);

            current_matrix.Draw(cons);
            current_matrix.Draw(form);
        }

        private void renumb_but_Click(object sender, EventArgs e)
        {
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);
            Renumbering_decorator decor;

            decor = new Renumbering_decorator(current_matrix);

            Random rnd = new Random();
            int num1 = 0, num2 = 0;
            while (num1==num2)
            {
                num1 = rnd.Next(0, 7);
                num2 = rnd.Next(0, 7);
            }
            decor.Renumber_row(num1, num2);
            decor.Renumber_сol(num1, num2);
            Console.WriteLine("  ");
            decor.Draw(cons);
            decor.Draw(form);
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);

            current_matrix.Draw(cons);
            current_matrix.Draw(form);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hor_gr = new HorizontalGroupOfMatrix();
            SimpleMatrix a = new SimpleMatrix(2, 2);
            InitiatorMatrix.RandomMatr(a, 4, 100);
            hor_gr.AddComponent(a);
            SparseMatrix m = new SparseMatrix(5, 4);
            InitiatorMatrix.RandomMatr(m, 5, 7);
            hor_gr.AddComponent(m);

            Console.Clear();
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);

            current_matrix = hor_gr;
            current_matrix.Draw(cons);
            current_matrix.Draw(form);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hor_gr = new HorizontalGroupOfMatrix();
            SparseMatrix a = new SparseMatrix(2, 2);
            InitiatorMatrix.RandomMatr(a, 4, 100);
            hor_gr.AddComponent(a);
            SparseMatrix m = new SparseMatrix(5, 4);
            InitiatorMatrix.RandomMatr(m, 5, 7);
            hor_gr.AddComponent(m);

            Console.Clear();
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);

            current_matrix = hor_gr;
            current_matrix.Draw(cons);
            current_matrix.Draw(form);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);
            Transponir_decorator decor;

            decor = new Transponir_decorator(hor_gr);

            Console.WriteLine("  ");
            decor.Draw(cons);
            //decor.Draw(form);
        }
    }
}
