namespace Matrices
{
    using System;
    using System.Globalization;
    using System.Text;

    public class Matrix<T> where T : struct, IConvertible
    {
        // fields
        private int rows;
        private int cols;
        private T[,] matrix;

        // constrictors
        public Matrix(int rowCount, int colCount)
        {
            this.matrix = new T[rowCount, colCount];
            this.Rows = rowCount;
            this.Cols = colCount;
        }

        // properties
        public int Cols
        {
            get
            {
                return this.cols;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("matrix cannot have negative number columns");
                }

                this.cols = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("matrix cannot have negative number rows");
                }

                this.rows = value;
            }
        }

        // indexer
        public T this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex < 0 || rowIndex >= this.rows || colIndex < 0 || colIndex >= this.cols)
                {
                    throw new IndexOutOfRangeException("The matrix does not contain such index!");
                }

                return this.matrix[rowIndex, colIndex];
            }

            set
            {
                if (rowIndex < 0 || rowIndex >= this.rows || colIndex < 0 || colIndex >= this.cols)
                {
                    throw new IndexOutOfRangeException("The matrix does not contain such index!");
                }

                this.matrix[rowIndex, colIndex] = value;
            }
        }

        // override operators
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Cols != second.Cols || first.Rows != second.Rows)
            {
                throw new ArgumentException("Both matices must have equal rows nad equal columns!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(first.Rows, first.Cols);

            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0; j < first.Cols; j++)
                {
                    /*
                    This is a try to avoid the dynamic casting, this is not the right way also but is different tha oter homeworks :)
                    In the current case it looks OK because the generic matrix shoud handele different types of numbers which all inherit : struct, IConvertible.
                    I'm not sure about the the syntax but it works :) source: http://stackoverflow.com/questions/14020486/operator-overloading-with-generics
                     */
                    resultMatrix[i, j] = (T)Convert.ChangeType(
                        first[i, j].ToDecimal(CultureInfo.CurrentCulture) 
                        + second[i, j].ToDecimal(CultureInfo.CurrentCulture), 
                        typeof(T));
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Cols != second.Cols || first.Rows != second.Rows)
            {
                throw new ArgumentException("Both matices must have equal rows nad equal columns!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(first.Rows, first.Cols);

            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0; j < first.Cols; j++)
                {
                    resultMatrix[i, j] = (T)Convert.ChangeType(
                        first[i, j].ToDecimal(CultureInfo.CurrentCulture)
                        - second[i, j].ToDecimal(CultureInfo.CurrentCulture), 
                        typeof(T));
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrix, T number)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrix.Rows, matrix.Cols);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    resultMatrix[i, j] = (T)Convert.ChangeType(
                        matrix[i, j].ToDecimal(CultureInfo.CurrentCulture)
                        * number.ToDecimal(CultureInfo.CurrentCulture),
                        typeof(T));
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Cols != second.Rows)
            {
                throw new ArgumentException("The columns of the forst matrix shoud be equal to rows of the second matrix!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(first.Rows, second.Cols);

            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0; j < second.Cols; j++)
                {
                    /*
                     The cast to dynamic seems to be a good idea :) Don't do this at home :D
                    */ 

                    T currentElement = (T)Convert.ChangeType(0m, typeof(T));

                    for (int h = 0; h < second.Rows; h++)
                    {
                        currentElement = (T)Convert.ChangeType(
                            currentElement.ToDecimal(CultureInfo.CurrentCulture)
                            + (first[i, h].ToDecimal(CultureInfo.CurrentCulture)
                            * second[h, j].ToDecimal(CultureInfo.CurrentCulture)),
                            typeof(T));
                    }

                    resultMatrix[i, j] = currentElement;
                }
            }

            return resultMatrix;
        }

        // override ToString()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    sb.Append(string.Format("{0, 3} ", this.matrix[i, j]));                    
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
