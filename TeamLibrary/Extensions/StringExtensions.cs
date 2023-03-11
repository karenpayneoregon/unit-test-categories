using System.Text;

namespace TeamLibrary.Extensions;
public static class StringExtensions
{
    public static string Flatten(this List<string> list)
    {
        StringBuilder sb = new();
        foreach (string item in list)
        {
            sb.Append(item);
        }

        return sb.ToString();
    }
}
