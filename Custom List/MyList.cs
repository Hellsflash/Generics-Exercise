using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MyList<T> : IMyList<T>, IEnumerable<T>
    where T : IComparable
{
    private IList<T> list;

    public MyList()
        : this(Enumerable.Empty<T>())
    {
    }

    public MyList(IEnumerable<T> collection)
    {
        this.list = new List<T>(collection);
    }

    public void Add(T element) => this.list.Add(element);

    public T Remove(int index)
    {
        var temp = this.list[index];
        this.list.RemoveAt(index);
        return temp;
    }

    public bool Contains(T element) => this.list.Contains(element);

    public void Swap(int index1, int index2)
    {
        var temp = this.list[index1];
        this.list[index1] = this.list[index2];
        this.list[index2] = temp;
    }

    public int CountGreaterThan(T element) => this.list.Count(x => x.CompareTo(element) > 0);

    public T Max() => this.list.Max();

    public T Min() => this.list.Min();

    public IEnumerator<T> GetEnumerator() => this.list.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}