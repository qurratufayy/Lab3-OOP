using System;

namespace UML_Implement
{
    public class MatrixCalculator
    {
        private DimensionValidator validator;

        public MatrixCalculator(DimensionValidator validator)
        {
            this.validator = validator;
        }

        public Matrix add(Matrix A, Matrix B)
        {
            if (!validator.validateMatrixAddition(A, B))
            {
                throw new InvalidOperationException("Matrix dimensions are not compatible.");
            }

            int rows = A.rows;
            int cols = A.cols;
            Matrix result = new Matrix(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double sum = A.getValue(i, j) + B.getValue(i, j);
                    result.setValue(i, j, sum);
                }
            }

            return result;
        }
    }
}