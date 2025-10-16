//int[,] matrix = new int[3, 4];

//int[,] matrix =
//{
//    new Array[] {1, 2, 3 },
//    { 4, 5, 6 }
//};

//matrix.ForEach(row => Console.WriteLine(string.Join(" ", row)));

//////////////////////////////////



//int[] input = Console.ReadLine()
//    .Split().
//    Select(int.Parse).
//    ToArray();

//int rows = input[0];
//int cols = input[1];

///////////////////////////////////////////////
//int[,] matrix = ReadMatrix();

//static int[,] ReadMatrix()
//{
//    //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    Console.WriteLine("Rows: ");
//    int rows = int.Parse(Console.ReadLine());

//    Console.WriteLine("Cols: ");
//    int cols = int.Parse(Console.ReadLine());

//    int[,] matrix = new int[rows, cols];

//    for (int i = 0; i < rows; i++)
//    {
//        int[] matrixContent = Console.ReadLine().Split().Select(int.Parse).ToArray();

//        for (int j = 0; j < cols; j++)
//        {
//            matrix[i, j] = matrixContent[j];
//        }
//    }

//    return matrix;
//}

////////////////////////////////////////////////


///

int rows = 3;
int cols = 3;

int[,] matrix = ReadMatrix(rows, cols);

static int[,] ReadMatrix(int rows, int cols)
{
    int[,] resultMatrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int j = 0; j < cols; j++)
        {
            resultMatrix[i, j] = input[j];
        }
    }

    return resultMatrix;
}