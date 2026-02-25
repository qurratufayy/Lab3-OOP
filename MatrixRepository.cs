using System;
using System.Collections.Generic;

namespace UML_Implement
{
    public class MatrixRepository
    {
        private List<Matrix> matrices;

        public MatrixRepository()
        {
            matrices = new List<Matrix>();
        }

        public void addMatrix(Matrix m)
        {
            matrices.Add(m);
        }

        public Matrix getMatrix(int index)
        {
            if (index >= 0 && index < matrices.Count)
            {
                return matrices[index];
            }
            throw new IndexOutOfRangeException();
        }
    }
}