using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Matrix
    {
        public int n1, n2;
        double[,] m;

        public Matrix(int _n)
        {
            n1 = _n;
            n2 = _n;
            m = new double[n1, n2];
        }

        public Matrix(int _n1, int _n2)
        {
            n1 = _n1;
            n2 = _n2;
            m = new double[n1, n2];
        }

        public double this[int x, int y]
        {
            get { return m[x, y]; }
            set { m[x, y] = value; }
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            var res = new Matrix(m1.n1, m2.n2);

            for (int i = 0; i < m1.n1; ++i)
            {
                for (int j = 0; j < m2.n2; ++j)
                {
                    for (int k = 0; k < m2.n1; ++k)
                    {
                        res.m[i, j] += m1.m[i, k] * m2.m[k, j];
                    }
                }
            }

            return res;
        }
    }
}
