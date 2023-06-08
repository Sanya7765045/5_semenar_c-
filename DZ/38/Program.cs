// Функция генерирует массив из случайных вещественных чисел в заданном диапазоне
// size - размер массива
// minValue - минимальное значение, которое может принимать элемент массива
// maxValue - максимальное значение, которое может принимать элемент массива
// Возвращает сгенерированный массив
static double[] GenerateArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        // Генерируем случайное вещественное число в заданном диапазоне и добавляем его в массив
        array[i] = Math.Round(rand.NextDouble() * (maxValue - minValue) + minValue, 2);
    }
    // Возвращаем сгенерированный массив
    return array;
}

// Функция считает разность между максимальным и минимальным значениями в массиве
// array - массив, в котором нужно выполнить поиск
// Возвращает разность между максимальным и минимальным значениями в массиве
static double CalculateDifferenceBetweenMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        // Если текущее значение больше максимального, обновляем максимальное значение
        if (array[i] > max)
            max = array[i];
        // Если текущее значение меньше минимального, обновляем минимальное значение
        if (array[i] < min)
            min = array[i];
    }
    // Вычисляем разность между максимальным и минимальным значениями в массиве
    double result = max - min;
    // Возвращаем результат подсчета
    return result;
}

// Очищаем консоль
Console.Clear();

// Генерируем массив из 10 случайных вещественных чисел в диапазоне от -999 до 999
double[] generatedArray = GenerateArray(10, -999, 999);

// Считаем разность между максимальным и минимальным значениями в сгенерированном массиве
double result = CalculateDifferenceBetweenMaxAndMin(generatedArray);

// Выводим сообщение о результате подсчета и элементы массива на консоль
Console.WriteLine($"Разность между максимальным и минимальным значениями в массиве равна {result}");
for (int i = 0; i < generatedArray.Length; i++)
    Console.Write($"{generatedArray[i]} ");