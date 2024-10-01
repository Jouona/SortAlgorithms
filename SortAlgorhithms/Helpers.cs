namespace SortAlgorhithms;

public static class ArrayExtensions
{
    public static string ToCustomString(this int[] array)
    {
        return $"[{string.Join(", ", array)}]";
    }
}