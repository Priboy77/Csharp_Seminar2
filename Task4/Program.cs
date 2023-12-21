 // Задаем исходный двумерный массив
        int[,] array = {
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 3, 6, 9 }
        };
        int minRowIndex = 0, minColIndex = 0;
        int minValue = array[0, 0];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minValue)
                {
                    minValue = array[i, j];
                    minRowIndex = i;
                    minColIndex = j;
                }
            }
        }
        int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

        for (int i = 0, newI = 0; i < array.GetLength(0); i++)
        {
            if (i == minRowIndex)
                continue;

            for (int j = 0, newJ = 0; j < array.GetLength(1); j++)
            {
                if (j == minColIndex)
                    continue;

                newArray[newI, newJ] = array[i, j];
                newJ++;
            }

            newI++;
        }
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                Console.Write(newArray[i, j] + " ");
            }
            Console.WriteLine();
        }