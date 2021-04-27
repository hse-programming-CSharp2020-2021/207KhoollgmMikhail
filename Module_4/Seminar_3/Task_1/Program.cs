using System;

namespace Task_1
{
    class Matrix2
    {
        double[][] matrix;

        public Matrix2(double a1, double a2, double a3, double a4)
        {
            matrix = new double[2][];
            matrix[0] = new double[2];
            matrix[1] = new double[2];
            matrix[0][0] = a1; matrix[0][1] = a2;
            matrix[1][0] = a3; matrix[1][1] = a4;
        }

        public Matrix2(double d1, double d2)
        {
            matrix = new double[2][];
            matrix[0] = new double[2];
            matrix[1] = new double[2];
            matrix[0][0] = d1;
            matrix[1][1] = d2;
        }

        public Matrix2(Matrix2 matrix1)
        {
            matrix = new double[2][];
            matrix[0] = new double[2];
            matrix[1] = new double[2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    this.matrix[i][j] = matrix1.matrix[i][j];
                }
        }

        public double Det()
        {
            return matrix[0][0] * matrix[1][1] - (matrix[0][1] * matrix[1][0]);
        }

        public Matrix2 Inverse()
        {
            double det = Det();

            Matrix2 mat = new Matrix2(0, 0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    mat.matrix[i][j] = Math.Pow(-1, (i + j)) * matrix[1 - i][1 - j] / det;
                }

            return mat.Transpose();
        }

        public Matrix2 Transpose()
        {
            Matrix2 mat = new Matrix2(this);
            double tmp = mat.matrix[0][1];
            mat.matrix[0][1] = mat.matrix[1][0];
            mat.matrix[1][0] = tmp;
            return mat;
        }

        public static Matrix2 operator +(Matrix2 mat1, Matrix2 mat2)
        {
            Matrix2 mat = new Matrix2(0, 0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    mat.matrix[i][j] = mat1.matrix[i][j] + mat2.matrix[i][j];
                }

            return mat;
        }

        public static Matrix2 operator -(Matrix2 mat1, Matrix2 mat2)
        {
            Matrix2 mat = new Matrix2(0, 0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    mat.matrix[i][j] = mat1.matrix[i][j] - mat2.matrix[i][j];
                }

            return mat;
        }

        public static Matrix2 operator *(Matrix2 mat1, Matrix2 mat2)
        {
            Matrix2 mat = new Matrix2(0,0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    double sum = 0;
                    for (int l = 0; l < 2; l++)
                    {
                        sum += mat1.matrix[i][l] * mat2.matrix[l][j];
                    }
                    mat.matrix[i][j] = sum;
                }

            return mat;
        }

        public static Matrix2 operator *(Matrix2 mat1, double value)
        {
            Matrix2 mat = new Matrix2(mat1);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    mat.matrix[i][j] *= value;
                }

            return mat;
        }
        public static Matrix2 operator /(Matrix2 mat1, double value)
        {
            Matrix2 mat = new Matrix2(mat1);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    mat.matrix[i][j] /= value;
                }

            return mat;
        }

        public override string ToString()
        {

            return matrix[0][0].ToString("f2") + " " + matrix[0][1].ToString("f2") + "\n"
                + matrix[1][0].ToString("f2") + " " + matrix[1][1].ToString("f2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Matrix2(1, 2, 3, 4)) * (new Matrix2(1, 2, 3, 4).Inverse()));
        }
    }
}
