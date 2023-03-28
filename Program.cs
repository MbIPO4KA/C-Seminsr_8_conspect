/*vЗадача 53: Задайте двумерный массив.
 Напишите программу, которая поменяет местами первую и последнюю строку массива.*/

//Метод должен заполнять двумерный массив 
//значит он возвращает заполненный двумерный массив
// тип возвращаемого значения это двумерный массив целых чисел
// Get - получить, matrix - двумерная табличка
/*/// <summary>
/// Этот метод заполняет двумерный массив
/// числами от min до max (общее описание)
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненнвй двумерный массив целых чисел</returns>
int[,] GetMatrix(int rows, int cols, int min, int max)
{
    // Чтобы создать двумерный массив мы создаём некую матрицу
    int[,] matrix = new int[rows, cols];
    // наш двумерный массив проходим сначала по строчкам, потом по столбцам
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
//===========================================================
/// <summary>
/// Метод печатает матрицу, переданную на вход
/// </summary>
/// <param name="inputMatrix"> Входная матрица</param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0);i ++)
    {
            for (int j = 0; j < inputMatrix.GetLength(1);j ++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// 1. Заполним таблицу.
// Создадим пустую матрицу
int[,] rezultMatrix = GetMatrix(4,4,0,10);

// 2. Печать матрицы
PrintMatrix(rezultMatrix);

//============================================================

// Нам потребуется метод, который меняет строчки местами
// метод будет воспринимать матрицу, будет менять первую строчку с последней
// поиграем с методом void здесь по-интересней
/// <summary>
/// Метод меняет первую и последнюю строчку местами
/// </summary>
/// <param name="matr">просто матрицу (двумерный массив)</param>
void ChengeRowz(int[,] matr)
{
    //для того, чтобы найти номер последней строчки
    // введём переменную 
    // Давайте получим общее количество строчек
    // Обратимся к нашей матрице matr и используем свойство GetLength
    // чтобы понять, что это строчки пишем число 0
    int lastRow = matr.GetLength(0)-1; 
    //нам нужен индекс. matr.GetLength(0) - это РАЗМЕР
    // от размера отнимаем единичку получаем ИНДЕКС
    // Проходимся циклом for только по столбцам
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        // Складываем в некую переменную temp содержимое 
        //из 0 строчки и i столбца
        int temp = matr[0,i];
        // складываем этот же элемент из нулевой строчки в элемент последней строчки
        matr[0,i] = matr[lastRow,i];
        //Чтобы в последней строчке и первоц не было одинаковых значений
        //складываем в последнюю строчку данные из переменной temp
        matr[lastRow,i] = temp;
    }
    //осталось вызвать метод

}
Console.WriteLine(" Результирующая матрица : ");

// Дальше мы вызываем метод , который меняет строчку ChengeRowz
//он воспринимает на вход как раз так-и матрицу
// передаём массив, с которым производим все махинации это rezultMatrix
ChengeRowz(rezultMatrix);

// и мы так же вызываем метод который печатает матрицу с замененными данными
PrintMatrix(rezultMatrix);

//==========================================

/* В чистоте у нас видно :
int[,] rezultMatrix = GetMatrix(4,4,0,10);
PrintMatrix(rezultMatrix);
ChengeRowz(rezultMatrix);
PrintMatrix(rezultMatrix);*/

//==========================================

/*Задача 55: Задайте двумерный массив. Напишите программу,
 которая заменяет строки на столбцы. В случае, если это невозможно,
  программа должна вывести сообщение для пользователя.*/

// Введём две переменных и сделаем условие на равенство

/*int rows = 4;
int cols = 4;
if(rows !=cols) // проверка на неравенство
{
    Console.WriteLine("Матрица прямоугольная");
    return;
}
// 1. Заполним таблицу.
// Создадим пустую матрицу
int[,] rezultMatrix = GetMatrix(rows,cols,0,10);
/// <summary>
/// Этот метод заполняет двумерный массив
/// числами от min до max (общее описание)
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненнвй двумерный массив целых чисел</returns>
int[,] GetMatrix(int rows, int cols, int min, int max)
{
    // Чтобы создать двумерный массив мы создаём некую матрицу
    int[,] matrix = new int[rows, cols];
    // наш двумерный массив проходим сначала по строчкам, потом по столбцам
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
//===========================================================
/// <summary>
/// Метод печатает матрицу, переданную на вход
/// </summary>
/// <param name="inputMatrix"> Входная матрица</param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0);i ++)
    {
            for (int j = 0; j < inputMatrix.GetLength(1);j ++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// 2. Печать матрицы
PrintMatrix(rezultMatrix);
//===========================================================

// И остался метод, который меняет местами наши числа
// Копируем GetMatrix и правим
// Чтобы заменить наш массив мы должны воспринимать на вход 
// какую-то входную матрицу и работать только с ней

/// <summary>
/// Меняем строчки и столбцы местами
/// </summary>
/// <param name="matrix">Двумерный массив</param>
/// <returns>Матрица в которой поменяли строчки со столбцами</returns>


int[,] ChangeArray(int[,] matrix)
{
    // Чтобы создать двумерный массив мы создаём некую результирующую матрицу матрицу
    int[,] rezaltMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    // наш двумерный массив проходим сначала по строчкам, потом по столбцам
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            rezaltMatrix[i, j] = matrix[j, i];
        }
    }
    return rezaltMatrix;
}
Console.WriteLine(" Результирующая матрица : ");
PrintMatrix(ChangeArray(rezultMatrix));*/

//=================================================================

//Зададим параметры матрицы
int rows = 5;

int cols = 5;

//Есть массив
int[,] matrix = new int[rows, cols];
 
 // нужно найти минимальный элемент
 int min = int.MaxValue;   // int min = matrix[0,0];   ни кто не обидится

 //  и введём две переменных
 int indexMinRows = 0; // индекс строчки с минимальным элементом
 int indexMinCols = 0; // индекс столбца с минимальным элементом

 // ищем минимальный элемент в нашем массиве
 for (int i = 0; i < rows; i++)
 {
    for (int j = 0; j < cols; j++)
    {
        //заполним матрицу
        matrix[i, j] = new Random().Next(11);
        // и сразу распечатаем
        Console.Write(matrix[i, j] + " \t");

        if (min > matrix[i, j])
        {
            min = matrix[i, j];
            //и запоминаем этот результат в индексах. Фиксируем
            indexMinRows = i;
            indexMinCols = j;
        }
    }
    Console.WriteLine();  // пустая строчка
 }
 Console.WriteLine($"минимальный элемент: {min}, строчка {indexMinRows}, столбец {indexMinCols}");

 // нашли строчку и столбец, а теперь как их исключить
 for (int i = 0; i < rows; i++)
 {
    // сейчас будем печатать наши элементы массива, но не все
    // а только те, где номер строчки i не равен строчки с минимальным элементом
    if(i != indexMinRows )
    {
        for (int j = 0; j < cols; j++)
        {
            if(j != indexMinCols)
            {
                // ну и выводим на печать
                Console.Write(matrix[i, j] + " \t");
            }
        }
        Console.WriteLine();  // ��������а�� ����
    }
 }