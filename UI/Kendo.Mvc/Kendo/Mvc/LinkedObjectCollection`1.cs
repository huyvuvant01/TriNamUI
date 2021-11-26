// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.LinkedObjectCollection`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc
{
  public class LinkedObjectCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
    where T : LinkedObjectBase<T>
  {
    private readonly IList<T> innerList = (IList<T>) new List<T>();

    public LinkedObjectCollection(T parent) => this.Parent = parent;

    public T Parent { get; protected set; }

    public int Count => this.innerList.Count;

    public bool IsReadOnly => this.innerList.IsReadOnly;

    public T this[int index]
    {
      get => this.innerList[index];
      set
      {
        if (index < 0 || index >= this.innerList.Count)
          throw new ArgumentOutOfRangeException(nameof (index));
        T obj1 = default (T);
        T obj2 = default (T);
        if (index > 0)
        {
          obj1 = this.innerList[index - 1];
          obj1.NextSibling = value;
        }
        if (index + 1 < this.innerList.Count)
        {
          obj2 = this.innerList[index + 1];
          obj2.PreviousSibling = value;
        }
        value.Parent = this.Parent;
        value.PreviousSibling = obj1;
        value.NextSibling = obj2;
        this.Cleanup(index);
        this.innerList[index] = value;
      }
    }

    public void Add(T item)
    {
      item.Parent = this.Parent;
      if (this.innerList.Count > 0)
      {
        T inner = this.innerList[this.innerList.Count - 1];
        inner.NextSibling = item;
        item.PreviousSibling = inner;
      }
      this.innerList.Add(item);
    }

    public void Clear()
    {
      foreach (T inner in (IEnumerable<T>) this.innerList)
        LinkedObjectCollection<T>.Cleanup(inner);
      this.innerList.Clear();
    }

    public bool Contains(T item) => this.innerList.Contains(item);

    public void CopyTo(T[] array, int arrayIndex) => this.innerList.CopyTo(array, arrayIndex);

    public IEnumerator<T> GetEnumerator() => this.innerList.GetEnumerator();

    public int IndexOf(T item) => this.innerList.IndexOf(item);

    public void Insert(int index, T item)
    {
      if (index < 0 || index > this.innerList.Count)
        throw new ArgumentOutOfRangeException(nameof (index));
      if (index == this.innerList.Count)
      {
        this.Add(item);
      }
      else
      {
        item.Parent = this.Parent;
        T obj = default (T);
        if (index > 0)
        {
          obj = this.innerList[index - 1];
          obj.NextSibling = item;
        }
        T inner = this.innerList[index];
        inner.PreviousSibling = item;
        item.PreviousSibling = obj;
        item.NextSibling = inner;
        this.innerList.Insert(index, item);
      }
    }

    public bool Remove(T item)
    {
      int index = this.IndexOf(item);
      if (index <= -1)
        return false;
      this.RemoveAt(index);
      return true;
    }

    public void RemoveAt(int index)
    {
      if (index < 0 || index >= this.innerList.Count)
        throw new ArgumentOutOfRangeException(nameof (index));
      T obj1 = default (T);
      T obj2 = default (T);
      if (index > 0)
        obj1 = this.innerList[index - 1];
      if (index + 1 < this.innerList.Count)
        obj2 = this.innerList[index + 1];
      if ((object) obj1 != null)
        obj1.NextSibling = obj2;
      if ((object) obj2 != null)
        obj2.PreviousSibling = obj1;
      this.Cleanup(index);
      this.innerList.RemoveAt(index);
    }

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    private static void Cleanup(T item)
    {
      item.PreviousSibling = default (T);
      item.NextSibling = default (T);
      item.Parent = default (T);
    }

    private void Cleanup(int index)
    {
      if (this.innerList.Count <= 0 || index <= -1 || index >= this.innerList.Count)
        return;
      LinkedObjectCollection<T>.Cleanup(this.innerList[index]);
    }
  }
}
