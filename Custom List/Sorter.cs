using System;
using System.Linq;

public class Sorter
{
    public static MyList<T> Sort<T>(MyList<T> customList)
        where T : IComparable
    {
        var temp = customList.ToArray();
        Array.Sort(temp);
        return new MyList<T>(temp);
    }
}