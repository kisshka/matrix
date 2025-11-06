using Matrix.Domain;

namespace TestProjectForMatrix
{
    public class MatrixTests
    {
        [Fact]
        public void MatrixMultiplyTest1()
        {
           //данные для теста
           int[,] matrixTest = new int[,] {
                { 1, 2, -4, -5 },
                { 0, -3, 5, -6},
                { 1, 3, 4, -2 },
            };
            //ожидаемый результат
            int expected = -720;

            Matrix.Domain.Matrix matrixTesting = new Matrix.Domain.Matrix(matrixTest);
            int actual = matrixTesting.NegativeNumbersMult();
            //сравнение ожидаемого и полученного результата
            Assert.Equal(expected, actual);
        }

        [Fact]
        private void MatrixMultiplyTest2()
        {

            int[,] matrixTest = new int[,] {
                    { 1, 2, 4, 5 },
                    { 0, 3, 5, 6},
                    { 1, 3, 4, 2 },
                };
            int expected = 0;
            Matrix.Domain.Matrix matrixTesting = new Matrix.Domain.Matrix(matrixTest);
            int actual = matrixTesting.NegativeNumbersMult();
            Assert.Equal(expected, actual);
        }

        [Fact]
        private void MatrixMultiplyEvenRowsTest1()
        {
            int[,] matrixTest = new int[,]
            {
                { 1, 2, -4, -5 },
                { 0, -3, 5, -6},
                { 1, 3, 4, -2 },
            };
            int expected = 18;
            Matrix.Domain.Matrix matrixTesting = new Matrix.Domain.Matrix(matrixTest);
           int actual = matrixTesting.NegativeNumbersMult(true);
            Assert.Equal(expected, actual);
        }

        [Fact]
        private void MatrixMultiplyEvenRowsTest2()
        {
            int[,] matrixTest = new int[,]
            {
                { 1, 2, -4, -5 },
                { 0, 3, 5, 6},
                { 1, 3, 4, -2 },
            };
            int expected = 0;
            Matrix.Domain.Matrix matrixTesting = new Matrix.Domain.Matrix(matrixTest);
            int actual = matrixTesting.NegativeNumbersMult(true);
            Assert.Equal(expected, actual);
        }


    }
}