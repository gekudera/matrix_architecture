﻿using sr2_GUI.Composite;
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
        int What_but = 0;

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

            simp = new SimpleMatrix(7, 6);
            InitiatorMatrix.RandomMatr(simp, 40, 100);

            simp.Draw(cons);
            simp.Draw(form);
            What_but = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.Clear();
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);

            if (What_but == 1)
            {
                simp.Draw(cons);
                simp.Draw(form);
            }
            else if (What_but == 2)
            {
                spars.Draw(cons);
                spars.Draw(form);
            }
  
        }

        private void but_sparse_Click(object sender, EventArgs e)
        {
            Console.Clear();
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);

            spars = new SparseMatrix(7, 7);
            InitiatorMatrix.RandomMatr(spars, 10, 100);

            spars.Draw(cons);
            spars.Draw(form);
            What_but = 2;
        }

        private void renumb_but_Click(object sender, EventArgs e)
        {
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);
            Renumbering_decorator decor;


            if (What_but == 1)
            {
                decor = new Renumbering_decorator(simp);
            }
            else
            {
                decor = new Renumbering_decorator(spars);
            }

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

            if (What_but ==1)
            {
                simp.Draw(cons);
                simp.Draw(form);
            }
            else if (What_but ==2)
            {
                spars.Draw(cons);
                spars.Draw(form);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HorizontalGroupOfMatrix horr_group = new HorizontalGroupOfMatrix();
            SimpleMatrix a = new SimpleMatrix(2, 2);
            InitiatorMatrix.RandomMatr(a, 4, 100);
            horr_group.AddComponent(a);
            SimpleMatrix m = new SimpleMatrix(3, 3);
            InitiatorMatrix.RandomMatr(m, 2, 7);
            horr_group.AddComponent(m);

            Console.Clear();
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);

            horr_group.Draw(cons);
            horr_group.Draw(form);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HorizontalGroupOfMatrix horr_group = new HorizontalGroupOfMatrix();
            SparseMatrix a = new SparseMatrix(2, 2);
            InitiatorMatrix.RandomMatr(a, 4, 100);
            horr_group.AddComponent(a);
            SparseMatrix m = new SparseMatrix(4, 4);
            InitiatorMatrix.RandomMatr(m, 2, 7);
            horr_group.AddComponent(m);

            Console.Clear();
            b = picBox.CreateGraphics();
            b.Clear(BackColor);

            cons = new DrawInConsole(checkBox1.Checked);
            form = new DrawInForm(b, checkBox1.Checked);

            horr_group.Draw(cons);
            horr_group.Draw(form);
        }
    }
}
