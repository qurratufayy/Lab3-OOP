using System;

namespace UML_Implement
{
    public class VectorCalculator
    {
        private DimensionValidator validator;

        public VectorCalculator(DimensionValidator validator)
        {
            this.validator = validator;
        }

        public Vector add(Vector A, Vector B)
        {
            if (!validator.validateVectorAddition(A, B))
            {
                throw new InvalidOperationException("Vector dimensions are not compatible.");
            }

            int size = A.size;
            Vector result = new Vector(size);

            for (int i = 0; i < size; i++)
            {
                double sum = A.getValue(i) + B.getValue(i);
                result.setValue(i, sum);
            }

            return result;
        }
    }
}