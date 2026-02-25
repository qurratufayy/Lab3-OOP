using System;

namespace UML_Implement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("LAB 3 - Classes, Objects & Encapsulation");
            Console.WriteLine("========================================\n");

            try
            {
                InputHandler inputHandler = new InputHandler();
                DimensionValidator validator = new DimensionValidator();
                MatrixCalculator matrixCalculator = new MatrixCalculator(validator);
                VectorCalculator vectorCalculator = new VectorCalculator(validator);
                MatrixRepository matrixRepository = new MatrixRepository();
                VectorRepository vectorRepository = new VectorRepository();

                Console.WriteLine("STEP 1: MATRIX INPUT");
                Console.WriteLine("\n--- First Matrix ---");
                Matrix matrix1 = inputHandler.inputMatrix();
                matrixRepository.addMatrix(matrix1);
                
                Console.WriteLine("\n--- Second Matrix ---");
                Matrix matrix2 = inputHandler.inputMatrix();
                matrixRepository.addMatrix(matrix2);

                Console.WriteLine("\nSTEP 2: VECTOR INPUT");
                Console.WriteLine("\n--- First Vector ---");
                Vector vector1 = inputHandler.inputVector();
                vectorRepository.addVector(vector1);
                
                Console.WriteLine("\n--- Second Vector ---");
                Vector vector2 = inputHandler.inputVector();
                vectorRepository.addVector(vector2);

                Console.WriteLine("\nSTEP 3: INPUT SUMMARY");
                Console.WriteLine("\nMatrix 1:");
                matrix1.display();
                Console.WriteLine("\nMatrix 2:");
                matrix2.display();
                
                Console.WriteLine("\nVector 1:");
                vector1.display();
                Console.WriteLine("\nVector 2:");
                vector2.display();

                Console.WriteLine("\nSTEP 4: MATRIX ADDITION");
                try
                {
                    Matrix matrixResult = matrixCalculator.add(matrix1, matrix2);
                    matrixRepository.addMatrix(matrixResult);
                    Console.WriteLine("Matrix Addition Result:");
                    matrixResult.display();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error in matrix addition: {ex.Message}");
                }

                Console.WriteLine("\nSTEP 5: VECTOR ADDITION");
                try
                {
                    Vector vectorResult = vectorCalculator.add(vector1, vector2);
                    vectorRepository.addVector(vectorResult);
                    Console.WriteLine("Vector Addition Result:");
                    vectorResult.display();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error in vector addition: {ex.Message}");
                }

                Console.WriteLine("\nSTEP 6: DEMONSTRATING VALIDATION");
                Matrix matrix3 = new Matrix(2, 2);
                Matrix matrix4 = new Matrix(3, 3);
                
                matrix3.setValue(0, 0, 1);
                matrix3.setValue(0, 1, 2);
                matrix3.setValue(1, 0, 3);
                matrix3.setValue(1, 1, 4);
                
                Console.WriteLine("Matrix 3 (2x2):");
                matrix3.display();
                Console.WriteLine("Matrix 4 (3x3):");
                matrix4.display();
                
                try
                {
                    Console.WriteLine("\nAttempting to add incompatible matrices...");
                    Matrix invalidResult = matrixCalculator.add(matrix3, matrix4);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Validation caught error: {ex.Message}");
                }

                Console.WriteLine("\n========================================");
                Console.WriteLine("LAB 3 COMPLETED SUCCESSFULLY!");
                Console.WriteLine("========================================");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}