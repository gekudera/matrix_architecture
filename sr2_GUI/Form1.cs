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
        SimpleMatrix simp;
        SparseMatrix spars;
        DrawInConsole cons;
        DrawInForm form;
        bool What_but = true;

        public Form1()
        {
            InitializeComponent();
            b = picBox.CreateGraphics();
            cons = new DrawInConsole();
            form = new DrawInForm(b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Clear();
            //b = picBox.CreateGraphics();
            b.Clear(BackColor);

            form = new DrawInForm(b);

            simp = new SimpleMatrix(7, 7);
            InitiatorMatrix.RandomMatr(simp, 40, 100);

            simp.Draw(checkBox1.Checked, cons);
            simp.Draw(checkBox1.Checked, form);
            What_but = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.Clear();
            //b = picBox.CreateGraphics();
            b.Clear(BackColor);

            form = new DrawInForm(b);

            if (What_but)
            {
                simp.Draw(checkBox1.Checked, cons);
                simp.Draw(checkBox1.Checked, form);
            }
            else
            {
                spars.Draw(checkBox1.Checked, cons);
                spars.Draw(checkBox1.Checked, form);
            }
  
        }

        private void but_sparse_Click(object sender, EventArgs e)
        {
            Console.Clear();
           // b = picBox.CreateGraphics();
            b.Clear(BackColor);

            form = new DrawInForm(b);

            spars = new SparseMatrix(7, 7);
            InitiatorMatrix.RandomMatr(spars, 10, 100);

            spars.Draw(checkBox1.Checked, cons);
            spars.Draw(checkBox1.Checked, form);
            What_but = false;
        }
    }
}
