{
    // Коментироование кода

    ///* В качестве задачи для работы с массивами, я выбрал упорядочивание данных
    //внутри массива. Существуют разные алгоритмы, которые вы, скорее всего, будете писать в
    //дальнейшем. Остановимся на одном из самых простых. Это так называемый алгоритм
    //сортировки методом выбора, ещё его называют алгоритм сортировки методом минимакса или
    //иногда просто называют методом максимального, или выбора максимального или выбора
    //минимального и так далее.

    // 1. Найти позицию минимального элемента в неотсортированной части массива.
    // 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
    // 3. Повторять пока есть неотсортированные элементы.
    // *\

    int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

    void PtintArray(int[] array)
    {
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]}");
        }
        Console.WriteLine();
    }

    void selectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minPosition])
                {
                    minPosition = j;
                }
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
    }
    PrintArray(arr);
    SelectionSort(arr);
    PrintArray(arr);

