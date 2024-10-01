using SortAlgorhithms;

class Program {
    static void Main(string[] args) {
        int[] array = new int[10000]; // Larger array size


        Random random = new Random();

        // Fill the array with random integers
        for (int i = 0; i < array.Length; i++) {
            array[i] = random.Next(1, 10001); // Random integers between 1 and 10,000
        }


        BaseSort quickSort = new QuickSort();
        BaseSort insertionSort = new InsertionSort();
        BaseSort selectionSort = new SelectionSort();
        BaseSort bubbleSort = new BubbleSort();

        quickSort.Sort(array);
        insertionSort.Sort(array);
        selectionSort.Sort(array);
        bubbleSort.Sort(array);

        Console.WriteLine("QuickSort");
        foreach (var data in quickSort.AllSortedData) {
            Console.WriteLine(data.TimeToString());
        }

        Console.WriteLine("InsertionSort");
        foreach (var data in insertionSort.AllSortedData) {
            Console.WriteLine(data.TimeToString());
        }

        Console.WriteLine("SelectionSort");
        foreach (var data in selectionSort.AllSortedData) {
            Console.WriteLine(data.TimeToString());
        }

        Console.WriteLine("BubbleSort");
        foreach (var data in bubbleSort.AllSortedData) {
            Console.WriteLine(data.TimeToString());
        }
    }
}