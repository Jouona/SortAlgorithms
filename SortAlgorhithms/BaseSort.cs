using System.Diagnostics;

public abstract class BaseSort : ISort {
    public List<SortData> AllSortedData => allSortedData;
    List<SortData> allSortedData = new List<SortData>();
    Stopwatch? stopwatch;

    public void Sort(int[] array) {
        int[] preSort = array;
        stopwatch = Stopwatch.StartNew();
        DoSort(array);
        stopwatch.Stop();
        SortData newData = new SortData(stopwatch.Elapsed.Milliseconds, preSort, array);
        allSortedData.Add(newData);
    }

    protected abstract void DoSort(int[] array);
}