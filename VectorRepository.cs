using System;
using System.Collections.Generic;

namespace UML_Implement
{
    public class VectorRepository
    {
        private List<Vector> vectors;

        public VectorRepository()
        {
            vectors = new List<Vector>();
        }

        public void addVector(Vector v)
        {
            if (v != null)
            {
                vectors.Add(v);
            }
            else
            {
                throw new ArgumentNullException("v cannot be null");
            }
        }

        public Vector getVector(int index)
        {
            if (index >= 0 && index < vectors.Count)
            {
                return vectors[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Vector index out of range");
            }
        }
    }
}