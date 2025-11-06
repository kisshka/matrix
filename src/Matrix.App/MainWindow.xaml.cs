using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Matrix.Domain;


namespace lab_8testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Matrix.Domain.Matrix? matrix;
        public int columns;
        public int rows;
        public MainWindow()
        {
            InitializeComponent();
        }

        //создание пустой матрицы
        private void CreateMatrix_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                columns = int.Parse(ColumnsInput.Text);
                rows = int.Parse(RowsInput.Text);
                matrix = new Matrix.Domain.Matrix(rows, columns);
                DisplayMatrix();
            }
            catch (Exception)
            {
                string Message = "Пожалуйста, введите размер строк и колонок матрицы";
                MessageBox.Show(Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //создание рандомной матрицы
        private void GenerateMatrix_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                columns = int.Parse(ColumnsInput.Text);
                rows = int.Parse(RowsInput.Text);
                Random random = new Random();


               int[,] generate = new int[rows,columns];
                for (int i = 0; i < generate.GetLength(0); i++)
                 for (int j = 0; j < generate.GetLength(1); j++)
                    {
                        generate[i, j] = random.Next(-10, 11);
                    }
                matrix = new Matrix.Domain.Matrix(generate);
                DisplayMatrix();
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите размер строк и колонок матрицы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        //умноение
        private void MultiplyMatrix_Click(object sender, RoutedEventArgs e)
        {
            int multiplyResult;
            bool onlyEven = (bool)isEven.IsChecked;
            if (matrix!= null)
            {
                multiplyResult = matrix.NegativeNumbersMult(onlyEven);
                multResult.Text = multiplyResult.ToString();
            }
            else
                MessageBox.Show("Сначала нужно заполнить матрицу", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        // Вывод матрицы на экран
        private void DisplayMatrix()
        {
            MatrixDisplay.Items.Clear();
            for (int i = 0; i < matrix.getCols; i++)
            {
                string rowString = "";
                for (int j = 0; j < matrix.getRows; j++)
                {
                    rowString += matrix[i, j].ToString().PadRight(10);
                }
                MatrixDisplay.Items.Add(rowString.TrimEnd()); 
            }
        }

        private void EditMatrixElement_Click(object sender, RoutedEventArgs e)
        {
            int editCol = int.Parse(col.Text);
            int editRow = int.Parse(row.Text);
            int editVal= int.Parse(val.Text);

            matrix[editRow-1, editCol-1] = editVal;
            DisplayMatrix();

        }
    }
}