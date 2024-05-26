public class FenwickTree {
    private static int[] fenwickTree;
    private static int n;

    public static void BuildFenwickTree(int[] arr, int n) {
        // Определение размера n+1, потому что используется индексация с 1.
        fenwickTree = new int[n + 1];
        FenwickTree.n = n;
        // Вызов функции UpdateUtil для каждого индекса массива a.
        for (int i = 0; i < n; i++) {
            UpdateUtil(i, arr[i]);
        }
    }

    // Функция UpdateUtil для обновления массива fenwickTree.
    private static void UpdateUtil(int index, int delta) {
        // Увеличение индекса на 1 для поддержания индексации с 1.
        index++;
        // Итерация до тех пор, пока индекс находится в диапазоне массива.
        while (index <= n) {
            fenwickTree[index] += delta;
            index += (index & -index);
        }
    }

    public static void Update(int[] arr, int index, int val) {
        // Вычисление 'delta', который является изменением значения.
        int delta = val - arr[index];
        arr[index] = val;
        // Вызов функции UpdateUtil для обновления массива fenwickTree.
        UpdateUtil(index, delta);
    }

    // Функция для нахождения суммы элементов массива в диапазоне [0, ind].
    private static int FindSum(int index) {
        int sum = 0;
        // Итерация до тех пор, пока индекс находится в диапазоне массива.
        while (index > 0) {
            sum += fenwickTree[index];
            index -= (index & -index);
        }
        return sum;
    }

    // Функция для нахождения суммы элементов массива в диапазоне [left, right].
    public static int SumRange(int left, int right) {
        return FindSum(right + 1) - FindSum(left);
    }
}