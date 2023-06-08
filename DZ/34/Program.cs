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

// Эта функция считает количество четных чисел в массиве
// array - массив, в котором нужно выполнить поиск
// Возвращает количество найденных четных чисел
static int CountEvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        // Если текущий элемент массива четный, увеличиваем результат на 1
        if (array[i] % 2 == 0)
            result++;
    }
    // Возвращаем результат подсчета
    return result;
}

// Очищаем консоль
Console.Clear();

// Генерируем массив из 123 случайных целых чисел в диапазоне от -999 до 999
int[] generatedArray = GenerateArray(123, -999, 999);

// Считаем количество четных чисел в сгенерированном массиве
int result = CountEvenNumbers(generatedArray);

// Выводим сообщение о результате подсчета и элементы массива на консоль
Console.WriteLine($"В массиве ниже присутствует {result} четных чисел:");
for (int i = 0; i < generatedArray.Length; i++)
    Console.Write($"{generatedArray[i]} ");