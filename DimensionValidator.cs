using System;

namespace UML_Implement
{
    public class DimensionValidator
    {
        public bool validateMatrixAddition(Matrix A, Matrix B)
        {
            if (A == null || B == null)
                return false;

            return (A.rows == B.rows && A.cols == B.cols);
        }

        public bool validateVectorAddition(Vector A, Vector B)
        {
            if (A == null || B == null)
                return false;

            return (A.size == B.size);
        }
    }
}