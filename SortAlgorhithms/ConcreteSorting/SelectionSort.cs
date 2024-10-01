namespace SortAlgorhithms;

public class SelectionSort : BaseSort {
    protected override void DoSort(int[] array) {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++) {
            int minIndex = i;
            for (int j = i + 1; j < n; j++) {
                if (array[j] < array[minIndex]) {
                    minIndex = j;
                }
            }

            (array[minIndex], array[i]) = (array[i], array[minIndex]);
        }
    }
}