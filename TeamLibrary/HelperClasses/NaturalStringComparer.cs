using System.Runtime.InteropServices;

namespace TeamLibrary.HelperClasses;
public class NaturalStringComparer : Comparer<string>
{
    [DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
    private static extern int StrCmpLogicalW(string x, string y);

    public override int Compare(string left, string right) 
        => StrCmpLogicalW(left, right);
}