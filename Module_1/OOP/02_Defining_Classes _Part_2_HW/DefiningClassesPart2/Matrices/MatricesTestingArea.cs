namespace Matrices
{
    public class MatricesTestingArea
    {
        public static void Main(string[] args)
        {
            // set matrix one
            Matrix<int> firstMatr = new Matrix<int>(2, 2);
            firstMatr[0, 0] = 1;
            firstMatr[0, 1] = 3;
            firstMatr[1, 0] = 0;
            firstMatr[1, 1] = -2;

            // print matrix one
            System.Console.WriteLine("first matrix:");
            System.Console.WriteLine(firstMatr);

            // set matrix two
            Matrix<int> secondtMatr = new Matrix<int>(2, 2);
            secondtMatr[0, 0] = 7;
            secondtMatr[0, 1] = 9;
            secondtMatr[1, 0] = 5;
            secondtMatr[1, 1] = 2;

            // print matrix two
            System.Console.WriteLine("\nsecond matrix:");
            System.Console.WriteLine(secondtMatr);
            
            // adding the two matrices
            Matrix<int> sumMatrix = firstMatr + secondtMatr;

            // printing sum
            System.Console.WriteLine("\nsum of 2 matrices matrix:");
            System.Console.WriteLine(sumMatrix);

            // substracting the two matrices
            Matrix<int> subMatrix = firstMatr - secondtMatr;

            // printing result ot substracting
            System.Console.WriteLine("\nsubstract 2 matrices matrix:");
            System.Console.WriteLine(subMatrix);

            // multiplying two matrices (calculator to check the result :P http://matrix.reshish.com/multiplication.php)
            Matrix<int> prodMatrix = firstMatr * secondtMatr;

            // printing the product
            System.Console.WriteLine("\nproduct of 2 matrices matrix:");
            System.Console.WriteLine(prodMatrix);

            // multiply matrix one by number 2
            Matrix<int> prodMatrixAndNumber = firstMatr * 2;

            // rrinting the result
            System.Console.WriteLine("\nproduct of first matrix and 2:");
            System.Console.WriteLine(prodMatrixAndNumber);
        } 
    }
}