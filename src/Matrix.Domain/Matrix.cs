namespace Matrix.Domain
{
    public class Matrix
    {
        private int[,] _matrix;

        //конструкторы
        public Matrix(int colsQuantity, int rowsQuantity)
        {
            _matrix = new int[colsQuantity, rowsQuantity];
            for (int i = 0; i < colsQuantity; i++)
            {
                for (int j = 0; j < rowsQuantity; j++)
                {
                    _matrix[i, j] = 0;
                }
            }
        }

        public Matrix(int[,] umatrix)
        {
            _matrix = new int[umatrix.GetLength(0), umatrix.GetLength(1)];
            _matrix = umatrix;
        }

        //определение длины сторон матрицы
        public int getCols
        {
            get { return _matrix.GetLength(0); }
        }

        public int getRows
        {
            get { return _matrix.GetLength(1); }
        }

        public int this[int i, int j]
        {
            get { return _matrix[i, j]; }
            set { _matrix[i, j] = value; }
        }
        public int NegativeNumbersMult(bool rowsIsEven = false)
        {
            int multiply = 1;
            bool wasMult = false;

            for (int i = 0; i < getCols; i++)
            {
                for (int j = 0; j < getRows; j++)
                {
                    if (rowsIsEven)
                    {
                        if (_matrix[i, j] < 0 && i % 2 != 0)
                        {
                            multiply *= _matrix[i, j];
                            wasMult = true;
                        }

                    }
                    else
                    {
                        if (_matrix[i, j] < 0)
                        {
                            multiply *= _matrix[i, j];
                            wasMult = true;
                        }
                    }
                }
            }
            if (wasMult)
                return multiply;
            else return 0;

        }
    }

}
