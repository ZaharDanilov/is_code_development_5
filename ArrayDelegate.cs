using System;

namespace is_code_development_5
{
    // Делегат для сортировки массива
    public delegate void ArraySortDelegate<T>(T[] array) where T : IComparable<T>;

    // Делегат для вычисления размаха
    public delegate T ArrayRangeDelegate<T>(T[] array) where T : IComparable<T>;
}