public interface ISort {
    List<SortData> AllSortedData { get; }
    void Sort(int[] array);
}