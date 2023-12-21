{
        // Пример двумерного массива
        int[,] myArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        
        Console.Write("Введите номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите номер столбца: ");
        int column = Convert.ToInt32(Console.ReadLine());
        
        int value = GetValue(myArray, row, column);
        
        if (value != -1)
        {
            Console.WriteLine($"Значение элемента: {value}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет");
        }
    }

    static int GetValue(int[,] array, int row, int column)
    {
        int rowCount = array.GetLength(0);
        int columnCount = array.GetLength(1);
        
        if (row >= 0 && row < rowCount && column >= 0 && column < columnCount)
        {
            return array[row, column];
        }
        else
        {
            return -1; 
        }
    }
