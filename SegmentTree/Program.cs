class Program {
    static void Main(string[] args) {
        int[] data = {43, 18, 35, 12, 57, 76, 45, 15, 76, 24};

        SegmentTree sumTree = new SegmentTree(data, new SumOperation());
        SegmentTree minTree = new SegmentTree(data, new MinOperation());
        SegmentTree maxTree = new SegmentTree(data, new MaxOperation());
        SegmentTree multiplyTree = new SegmentTree(data, new MultiplyOperation());
        SegmentTree gcdTree = new SegmentTree(data, new GcdOperation());

        int start = 3;
        int end = 7;
        var segment = new Segment(start, end);

        System.Console.WriteLine("Массив: " + string.Join(" ", data));

/*         System.Console.WriteLine("Ввод вручную: ");
        Console.WriteLine($"Сумма элементов от [2; 4): " + sumTree.Query(1, 3));
        Console.WriteLine($"Минимальный элемент [2; 4): " + minTree.Query(1, 3));
        Console.WriteLine($"Максимальный элемент [2; 4) " + maxTree.Query(1, 3));
        Console.WriteLine("Произведенеи элементов [2; 4): " + multiplyTree.Query(1, 3));
        Console.WriteLine("НОД элементов [2; 4): " + gcdTree.Query(1, 3)); */

        System.Console.WriteLine();

        System.Console.WriteLine("Ввод через отрезок: ");
        Console.WriteLine($"Сумма элементов от [{start + 1}; {end + 1}): " + sumTree.Query(segment));
        Console.WriteLine($"Минимальный элемент [{start + 1}; {end + 1}): " + minTree.Query(segment));
        Console.WriteLine($"Максимальный элемент [{start + 1}; {end + 1}): " + maxTree.Query(segment));
        Console.WriteLine($"Произведенеи элементов [{start + 1}; {end + 1}): " + multiplyTree.Query(segment));
        Console.WriteLine($"НОД элементов [{start + 1}; {end + 1}): " + gcdTree.Query(segment));

        int updateIndex = 5;
        int updateValue = 100;

        minTree.Update(updateIndex, updateValue);
        sumTree.Update(updateIndex, updateValue);
        maxTree.Update(updateIndex, updateValue);
        multiplyTree.Update(updateIndex, updateValue);
        gcdTree.Update(updateIndex, updateValue);
        
        System.Console.WriteLine();
        System.Console.WriteLine("После обновления массива: ");
        System.Console.WriteLine();

/*         System.Console.WriteLine("Ввод вручную: ");
        Console.WriteLine($"Сумма элементов [2; 4) после обновления массива: " + sumTree.Query(1, 3));
        Console.WriteLine($"Минимальный элемент [2; 4) после обновления массива: " + minTree.Query(1, 3));
        Console.WriteLine($"Максималльный элемент [2; 4) после обновления массива: " + maxTree.Query(1, 3));
        Console.WriteLine("Произведение элементов [2; 4) после обновления массива: " + multiplyTree.Query(1, 3));
        Console.WriteLine("НОД [2; 4) после обновления массива: " + gcdTree.Query(1, 3)); */

        // System.Console.WriteLine();

        System.Console.WriteLine("Ввод через отрезок: ");
        Console.WriteLine($"Сумма элементов [{start + 1}; {end + 1}) после обновления массива [index {updateIndex}, value {updateValue}]: " + sumTree.Query(segment));
        Console.WriteLine($"Минимальный элемент [{start + 1}; {end + 1}) после обновления массива [index {updateIndex}, value {updateValue}]: " + minTree.Query(segment));
        Console.WriteLine($"Максималльный элемент [{start + 1}; {end + 1}) после обновления массива [index {updateIndex}, value {updateValue}]: " + maxTree.Query(segment));
        Console.WriteLine($"Произведение элементов [{start + 1}; {end + 1}) после обновления массива [index {updateIndex}, value {updateValue}]: " + multiplyTree.Query(segment));
        Console.WriteLine($"НОД [{start + 1}; {end + 1}) после обновления массива [index {updateIndex}, value {updateValue}]: " + gcdTree.Query(segment));

        
    }
}
