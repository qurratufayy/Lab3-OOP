using System;

namespace UML_Implement
{
    public class Vector
    {
        internal int size;
        private double[] data;

        public Vector(int size)
        {
            this.size = size;
            data = new double[size];
        }

        public void setValue(int i, double value)
        {
            data[i] = value;
        }

        public double getValue(int i)
        {
            return data[i];
        }

        public void display()
        {
            Console.Write("[ ");
            foreach (double val in data)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("]");
        }
    }
}