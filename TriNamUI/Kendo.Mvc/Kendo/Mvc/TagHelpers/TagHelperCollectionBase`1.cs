// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TagHelperCollectionBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  public abstract class TagHelperCollectionBase<T> : 
    TagHelperChildBase,
    IList<T>,
    ICollection<T>,
    IEnumerable<T>,
    IEnumerable
    where T : TagHelperCollectionItemBase
  {
    protected IList<T> InternalRef { get; set; }

    public TagHelperCollectionBase(IList<T> collection) => this.InternalRef = collection;

    public T this[int index]
    {
      get => this.InternalRef[index];
      set => this.InternalRef[index] = value;
    }

    public int Count => this.InternalRef.Count;

    public bool IsReadOnly => this.InternalRef.IsReadOnly;

    public void Add(T item) => this.InternalRef.Add(item);

    public void Clear() => this.InternalRef.Clear();

    public bool Contains(T item) => this.InternalRef.Contains(item);

    public void CopyTo(T[] array, int arrayIndex) => this.InternalRef.CopyTo(array, arrayIndex);

    public IEnumerator<T> GetEnumerator() => this.InternalRef.GetEnumerator();

    public int IndexOf(T item) => this.InternalRef.IndexOf(item);

    public void Insert(int index, T item) => this.InternalRef.Insert(index, item);

    public bool Remove(T item) => this.InternalRef.Remove(item);

    public void RemoveAt(int index) => this.InternalRef.RemoveAt(index);

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.InternalRef.GetEnumerator();
  }
}
