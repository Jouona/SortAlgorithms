namespace SortAlgorhithms;

public class QuickSort : BaseSort {
    // Äußere QuickSort-Methode, die nur das Array als Parameter nimmt
    protected override void DoSort(int[] array) {
        QuickSorting(array, 0, array.Length - 1);
    }

    // Innere rekursive QuickSort-Methode, die left und right benötigt
    void QuickSorting(int[] array, int left, int right) {
        if (left < right) {
            int pivotIndex = Partition(array, left, right);

            QuickSorting(array, left, pivotIndex - 1);
            QuickSorting(array, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right) {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++) {
            if (array[j] < pivot) {
                i++;

                // Tausche array[i] und array[j]
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        (array[i + 1], array[right]) = (array[right], array[i + 1]);

        return i + 1;
    }
}