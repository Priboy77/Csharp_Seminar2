 {
        // Создание двумерного массива
        int[,] myArray = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(myArray);

        int rows = myArray.GetLength(0);
        int columns = myArray.GetLength(1);

        int[] tempRow = new int[columns];
        for (int i = 0; i < columns; i++)
        {
            tempRow[i] = myArray[0, i];
            myArray[0, i] = myArray[rows - 1, i];
            myArray[rows - 1, i] = tempRow[i];
        }

        Console.WriteLine("Массив после замены строк:");
        PrintArray(myArray);
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }