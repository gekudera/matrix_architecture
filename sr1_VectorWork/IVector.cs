using System;
using System.Collections.Generic;
using System.Text;

namespace sr1_VectorWork
{
    interface IVector
    {
        public int Size { get; }
        public List<double> GetAllValues();          //отдает весь вектор
        public double GetValue(int i);           //отдает i-ое значение вектора
        public void AddValue(double chisl);      //добавляет значение в конец вектора
        public void SetValue(int h, double chislo);

    }
}
