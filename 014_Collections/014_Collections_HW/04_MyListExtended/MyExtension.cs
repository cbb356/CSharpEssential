namespace MyListExtended
{
    internal static class MyExtension
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            return list.ToArray();
        }
    }
}