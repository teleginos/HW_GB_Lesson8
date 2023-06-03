Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch(task)
{
    case 54:
        task54();
        break;
    case 56:
        task56();
        break;
    case 58:
        task58();
        break;
    case 62:
        task62();
        break;
    default:
        break;
}

int[,] CreationArray()
{
    Console.Write("Укажите желаемое кол-во строк в двумерном массиве: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите желаемое кол-во столбцов в двумерном массиве: ");
    int column = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[line, column];
    Random r = new Random();
    Console.WriteLine("Исходный массив: ");

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(1, 10);
            Console.Write($"{array[i,j]} ");
            
        }
        Console.WriteLine();
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

}

void task54()
{
    
    int[,] array = CreationArray();
    int arrayLine = array.GetLength(0);
    int arrayColumn = array.GetLength(1);

    for (int i = 0; i < arrayLine; i++)
    {
        for (int j = 0; j < arrayColumn - 1; j++)
        {
            for (int k = j + 1; k < arrayColumn; k++)
            {
                if (array[i,j] < array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    Console.WriteLine("Отсортированный массив: ");
    Print2DArray(array);
}

void task56()
{
    int[,] array = CreationArray();
    int minSumLineArray = int.MaxValue;
    int numberLine = -1;
    

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if (sum < minSumLineArray)
        {
            minSumLineArray = sum;
            numberLine = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов: {numberLine+1}");
}

void task58()
{
    int[,] array1 = CreationArray();
    int[,] array2 = CreationArray();

    int line1 = array1.GetLength(0);
    int column1 = array1.GetLength(1);
    int line2 = array2.GetLength(0);
    int column2 = array2.GetLength(1);

    if (line1 != column2)
    {
        Console.WriteLine("Перемножение матриц невозможно!");
        return;
    }

    int[,] result = new int[line1, column2];

    for (int i = 0; i < line1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int k = 0; k < column1; k++)
            {
                result[i,j] += array1[i,k] * array2[k,j];
            }
        }
    }
    Console.WriteLine($"Результат перемножения двух матриц: ");
    Print2DArray(result);
}

void task62()
{

}