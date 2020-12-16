using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI
{
    class HorizontalGroupOfMatrix : IMatrix
    {
        private int row, col;
        private int number;                //переменная с номером матрицы, стратегию которой мы хотим получить
        private int cur_matr, rememb;
        private List <IMatrix> list_matr;  //переменная-список из ссылок на объекты Матриц

        public int row_count { get { return row; } }

        public int column_count { get { return col; } }

        public HorizontalGroupOfMatrix()
        {
            row = 0;
            col = 0;
            number = 0;
            list_matr = new List<IMatrix>();
        }

        public void AddComponent(IMatrix matr)  //добавить матрицу
        {
            list_matr.Add(matr);

            if (matr.row_count > row)
            {
                row = matr.row_count;
            }
            col = col + matr.column_count;
        }

        public void Draw(IDrawing drawer)
        {
            drawer.DrawBorder(this);
            for (int i = 0; i < row; i++)
            {
                foreach (IMatrix matrix in list_matr)
                {
                    for (int j = 0; j < matrix.column_count; j++)
                    {
                        drawer.DrawUnit(matrix, i, j);
                    }
                    
                }
            }
            drawer.Print();
        }

        public IStrategy GetStrategy()
        {
            return (list_matr[number].GetStrategy()); 
        }

        public double GetValue(int i, int j)
        {
            cur_matr = 0;
            rememb = 0;
            for (int m = 0; m < list_matr.Count; m++)
            {
                if (i < (list_matr[m].column_count + rememb))
                {
                    cur_matr = m;
                }
                else
                {
                    rememb += list_matr[m].column_count;
                }
            }

            if (j < list_matr[cur_matr].row_count)
                return (list_matr[cur_matr]).GetValue(i, j);
            else
                return 0;
        }

        public void SetValue(double chisl, int i, int j)
        {
            cur_matr = 0;
            rememb = 0;
            for (int m = 0; m < list_matr.Count; m++)
            {
                if (i < (list_matr[m].column_count + rememb))
                {
                    cur_matr = m;
                }
                else
                {
                    rememb += list_matr[m].column_count;
                }
            }

            if (j < list_matr[cur_matr].row_count)
            {
                (list_matr[cur_matr]).SetValue(chisl, i, j);
            }

        }

        public void SetNumber(int num)
        {
            this.number = num;
        }

        public List<IMatrix> CopyList()  //используется только в транспонированном декораторе
        {
            return list_matr;
        }

    }
}
