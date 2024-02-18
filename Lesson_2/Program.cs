// Дан двумерный массив.
// 732
// 496
// 185
// Отсортировать данные в нем по возрастанию.
// 123
// 456
// 789
// Вывести результат на печать.

class Program

{
    static void Main(string[] args)
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        List<int> listOfNumbers = new List<int>();
        int aLength0 = a.GetLength(0);
        int aLength1 = a.GetLength(1);

        //Заполняем список значениями из двухмерного массива:
        for (int i = 0; i < aLength0; i++)
        {
            for (int j = 0; j < aLength1; j++)
            {
                listOfNumbers.Add(a[i, j]);
            }
        }

        listOfNumbers.Sort();  //Сортируем список

        //Заполняем двухмерный массив значениями из отсортированного списка:
        int index = 0;
        for (int i = 0; i < aLength0; i++)
        {
            for (int j = 0; j < aLength1; j++)
            {
                a[i, j] = listOfNumbers[index];
                index++;
            }
        }

        //Выводим отсортированный список на печать:
        for (int i = 0; i < aLength0; i++)
        {
            for (int j = 0; j < aLength1; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}