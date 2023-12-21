       // Задаем размеры двумерного массива
        int rows = 3;
        int columns = 4;
        int[,] array = new int[rows, columns];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 11);
            }
        }
        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        int minSum = int.MaxValue;
        int minSumRowIndex = -1;
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < columns; j++)
            {
                sum += array[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minSumRowIndex = i;
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1}");

       