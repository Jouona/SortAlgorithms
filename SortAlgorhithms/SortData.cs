using SortAlgorhithms;

public struct SortData(float time, int[] preSort, int[] postSort) {
    public float SortTime => time;
    public int[] PreSort => arrayPreSorted;
    public int[] ArraySorted => arraySorted;

    float sortTime = time;
    int[] arrayPreSorted = preSort;
    int[] arraySorted = postSort;

    public override string ToString() {
        string s = "SortData\n\n";
        s += "Array pre-sorted:\n" + arrayPreSorted.ToCustomString() + "\n" + "Array sorted:\n" +
             arraySorted.ToCustomString();
        s += "\nTime: " + sortTime + "\n\n\n\n";
        return s;
    }

    public string TimeToString() => "Time: " + sortTime + "\n\n";
}