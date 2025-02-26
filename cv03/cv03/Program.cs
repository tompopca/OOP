using static System.Runtime.InteropServices.JavaScript.JSType;

double[,] matrix1 = { { 1, 2 }, { 3, 4 } };
double[,] matrix2 = { { 5, 6 }, { 7, 8 } };
double[,] matrix3 = { { 2, 1, 3 }, { 1, 0, 2 } };

Matrix A = new Matrix(matrix1);
Matrix B = new Matrix(matrix2);
Matrix C = new Matrix(matrix3);

Console.WriteLine("Matrix A:\n\n{0}", A);
Console.WriteLine("Matrix B:\n\n{0}", B);
Console.WriteLine("Matrix C:\n\n{0}", C);


Console.WriteLine("\nA + B:");
Console.WriteLine(A+B);

Console.WriteLine("\nA - B:");
Console.WriteLine(A - B);

Console.WriteLine("\nA x B:");
Console.WriteLine(A * B);

Console.WriteLine("\n-A:");
Console.WriteLine(-A);

Console.WriteLine("\nDeterminant A: {0}", A.Determinant());

Console.WriteLine("\n Determinant C: {0}", C.Determinant());




Console.ReadLine();
