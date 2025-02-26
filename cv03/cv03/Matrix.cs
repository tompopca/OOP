using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Matrix
{
    private double[,] matrix;

    public Matrix(double[,] matrix)
    {
        this.matrix = matrix;
    }
    private int RowSize
    {
        get { return matrix.GetLength(0); }
    }

    private int ColumnSize
    {
        get { return matrix.GetLength(1); }
    }


    /// <summary>
    /// operátor sčítání
    /// </summary>
    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.RowSize != b.RowSize || a.ColumnSize != b.ColumnSize)
            throw new Exception("Incompatible matrix size");
        
        double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];
        for (int i = 0; i < a.RowSize; i++)
            for (int j = 0; j < a.ColumnSize; j++)
                resultMatrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
  
        return new Matrix(resultMatrix);
    }


    /// <summary>
    /// operátor odčítání
    /// </summary>
    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.RowSize != b.RowSize || a.ColumnSize != b.ColumnSize)
            throw new Exception("Incompatible matrix size");

        double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];
        for (int i = 0; i < a.RowSize; i++)
            for (int j = 0; j < a.ColumnSize; j++)
                resultMatrix[i, j] = a.matrix[i, j] - b.matrix[i, j];

        return new Matrix(resultMatrix);
    }

    /// <summary>
    /// operátor násobení
    /// </summary>
    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.ColumnSize != b.RowSize)
            throw new Exception("Incompatible matrix size");

        double[,] resultMatrix = new double[a.RowSize, b.ColumnSize];
        for (int i = 0; i < a.RowSize; i++)
            for (int j = 0; j < b.ColumnSize; j++)
                for (int k = 0; k < a.ColumnSize; k++)
                    resultMatrix[i, j] += a.matrix[i, k] * b.matrix[k, j];

        return new Matrix(resultMatrix);
    }

    /// <summary>
    /// operátor ==
    /// </summary>
        public static bool operator ==(Matrix a, Matrix b)
    {
        if (a.RowSize != b.RowSize || a.ColumnSize != b.ColumnSize)
            return false;

        for (int i = 0; i < a.RowSize; i++)
            for (int j = 0; j < a.ColumnSize; j++)
                if (a.matrix[i, j] != b.matrix[i, j])
                    return false;

        return true;
    }

    /// <summary>
    /// operátor !=
    /// </summary>
    public static bool operator !=(Matrix a, Matrix b)
    {
        return !(a == b);
    }

    /// <summary>
    /// operátor unární
    /// </summary>
    public static Matrix operator -(Matrix a)
    {
        double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];
        for (int i = 0; i < a.RowSize; i++)
            for (int j = 0; j < a.ColumnSize; j++)
                resultMatrix[i, j] = -a.matrix[i, j];

        return new Matrix(resultMatrix);
    }

    /// <summary>
    /// ToString
    /// </summary>
    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < RowSize; i++)
        {
            for (int j = 0; j < ColumnSize; j++)
                result += matrix[i, j] + "\t";
            result += "\n";
        }
        return result;
    }

    /// <summary>
    /// TDeterminant
    /// </summary>
    public double Determinant()
    {
        if (RowSize != ColumnSize)
            throw new Exception("Matrix must be square");

        if (RowSize == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else if (RowSize == 3)
        {
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                 - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                 + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }
        else
        {
            throw new Exception("Only 2x2 or 3x3 matrix");
        }
    }
}





