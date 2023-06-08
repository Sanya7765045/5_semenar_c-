// Эта функция генерирует массив из случайных целых чисел в заданном диапазоне
// size - размер массива
// minValue - минимальное значение, которое может принимать элемент массива
// maxValue - максимальное значение, которое может принимать элемент массива
// Возвращает сгенерированный массив
static int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        // Создаем новый объект класса Random и генерируем случайное число в заданном диапазоне
        array[i] = new Random().Next(minValue, maxValue + 1);
        // Выводим элемент массива на консоль
        //Console.Write($"{array[i]} ");    
    }
    // Возвращаем сгенерированный массив
    return array;
}

// Эта функция считает сумму чисел на нечетных позициях в массиве
// array - массив, в котором нужно выполнить поиск
// Возвращает сумму чисел на нечетных позициях
static int SumNumbersOnOddPositions(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        // Если текущий индекс массива нечетный, добавляем соответствующее число к результату
        result += array[i];
    }
    // Возвращаем результат подсчета
    return result;
}

// Очищаем консоль
Console.Clear();

// Генерируем массив из 10 случайных целых чисел в диапазоне от -999 до 999
int[] generatedArray = GenerateArray(10, -999, 999);

// Считаем сумму чисел на нечетных позициях в сгенерированном массиве
int result = SumNumbersOnOddPositions(generatedArray);

// Выводим сообщение о результате подсчета и элементы массива на консоль
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях массива ниже, равна {result}");
for (int i = 0; i < generatedArray.Length; i++)
    Console.Write($"{generatedArray[i]} ");