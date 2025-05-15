using System;
using is_code_development_5; // Указано правильное пространство имён

namespace is_code_development_5
{
    // Шаблонный класс для обработки одномерного массива с делегатами
    public class ArrayProcessor<T> where T : IComparable<T>
    {
        private T[] array; // Внутренний массив данных

        // Конструктор с ручным копированием массива
        public ArrayProcessor(T[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
                throw new ArgumentException("Массив не может быть пустым или null.");

            array = new T[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                array[i] = inputArray[i];
            }
        }

        // Свойство для доступа к массиву
        public T[] Array => array;

        // Делегат для сортировки
        public ArraySortDelegate<T> SortMethod { get; set; }

        // Делегат для вычисления размаха
        public ArrayRangeDelegate<T> RangeMethod { get; set; }

        // Метод для выполнения сортировки
        public void PerformSort()
        {
            SortMethod?.Invoke(array);
        }

        // Метод для вычисления размаха
        public T PerformRange()
        {
            if (RangeMethod == null)
                throw new InvalidOperationException("Метод вычисления размаха не задан.");
            return RangeMethod(array);
        }
    }
}