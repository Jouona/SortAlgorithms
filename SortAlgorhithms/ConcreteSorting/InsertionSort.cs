namespace SortAlgorhithms;

public class InsertionSort : BaseSort {
    protected override void DoSort(int[] array) {
        static void InsertionSort(int[] array) {
            for (int i = 1; i < array.Length; i++) {
                int key = array[i];

                int j = i - 1;

                /* Bewege die Elemente des Arrays, die größer als key sind,
                 um eine Position nach rechts */
                while (j >= 0 && array[j] > key) {
                    array[j + 1] = array[j];
                    j--;
                }

                // Setze key an die richtige Stelle
                array[j + 1] = key;
            }
        }
    }
}