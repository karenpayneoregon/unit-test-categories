namespace TeamLibrary.Extensions;
public static class ListExtensions
{

    // we can do the same thing without an extension 
    public static IEnumerable<T> Intersperse<T>(this IEnumerable<T> items, T separator)
    {
        bool first = true;
        foreach (T item in items)
        {
            if (first)
            {
                first = false;
            }
            else
            {
                yield return separator;
            }
            yield return item;
        }
    }
}
