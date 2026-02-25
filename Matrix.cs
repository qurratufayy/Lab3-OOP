using System;

namespace UML_Implement
{
    public class Matrix
    {
        internal int rows;
        internal int cols;
        private Row[] rowData;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            rowData = new Row[rows];
            
            for (int i = 0; i < rows; i++)
            {
                rowData[i] = new Row(cols);
            }
        }

        public void setValue(int i, int j, double value)
        {
            if (i >= 0 && i < rows)
            {
                rowData[i].setValue(j, value);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public double getValue(int i, int j)
        {
            if (i >= 0 && i < rows)
            {
                return rowData[i].getValue(j);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void display()
        {
            for (int i = 0; i < rows; i++)
            {
                rowData[i].display();
                Console.WriteLine();
            }
        }
    }
}