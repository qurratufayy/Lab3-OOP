using System;

namespace UML_Implement
{
    public class InputHandler
    {
        public Matrix inputMatrix()
        {
            Console.WriteLine("=== Matrix Input ===");
            Console.Write("Enter number of rows: ");
            string inputRows = Console.ReadLine() ?? "0";
            int rows = int.Parse(inputRows);
            
            Console.Write("Enter number of columns: ");
            string inputCols = Console.ReadLine() ?? "0";
            int cols = int.Parse(inputCols);

            Matrix matrix = new Matrix(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Value [{i}, {j}]: ");
                    string inputVal = Console.ReadLine() ?? "0";
                    double value = double.Parse(inputVal);
                    matrix.setValue(i, j, value);
                }
            }
            return matrix;
        }

        public Vector inputVector()
        {
            Console.WriteLine("=== Vector Input ===");
            Console.Write("Enter vector size: ");
            string inputSize = Console.ReadLine() ?? "0";
            int size = int.Parse(inputSize);

            Vector vector = new Vector(size);

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Value [{i}]: ");
                string inputVal = Console.ReadLine() ?? "0";
                double value = double.Parse(inputVal);
                vector.setValue(i, value);
            }
            return vector;
        }
    }
}