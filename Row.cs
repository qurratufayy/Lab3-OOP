using System;

namespace UML_Implement
{
    public class Row
    {
        private double[] values;

        public Row(int size)
        {
            values = new double[size];
        }

        public void setValue(int j, double value)
        {
            values[j] = value;
        }

        public double getValue(int j)
        {
            return values[j];
        }

        public int length()
        {
            return values.Length;
        }

        public void display()
        {
            Console.Write("[ ");
            foreach (double val in values)
            {
                Console.Write(val + " ");
            }
            Console.Write("]");
        }
    }
}