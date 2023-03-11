
using System.Numerics;

namespace TeamLibrary.Extensions;

public static class GenericExtensions
{
    /// <summary>Compares two values to compute which is lesser and returning the other value if an input is <c>NaN</c>.</summary>
    public static T GetMinNumber<T>(this T a, T b) where T : INumber<T>
        => T.MinNumber(a, b);

    /// <summary>Compares two values to compute which is greater and returning the other value if an input is <c>NaN</c>.</summary>
    public static T GetMaxNumber<T>(this T a, T b) where T : INumber<T>
        => T.MaxNumber(a, b);

}