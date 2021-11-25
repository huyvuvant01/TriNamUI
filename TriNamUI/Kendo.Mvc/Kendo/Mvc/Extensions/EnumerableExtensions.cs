// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.EnumerableExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


#nullable enable
namespace Kendo.Mvc.Extensions
{
  public static class EnumerableExtensions
  {
    public static void Each<T>(this 
    #nullable disable
    IEnumerable<T> instance, Action<T, int> action)
    {
      int num = 0;
      foreach (T obj in instance)
        action(obj, num++);
    }

    public static void Each<T>(this IEnumerable<T> instance, Action<T> action)
    {
      foreach (T obj in instance)
        action(obj);
    }

    public static IEnumerable AsGenericEnumerable(this IEnumerable source)
    {
      Type type = typeof (object);
      if (source.GetType().FindGenericType(typeof (IEnumerable<>)) != (Type) null)
        return source;
      IEnumerator enumerator = source.GetEnumerator();
      while (enumerator.MoveNext())
      {
        if (enumerator.Current != null)
        {
          type = enumerator.Current.GetType();
          try
          {
            enumerator.Reset();
            break;
          }
          catch
          {
            break;
          }
        }
      }
      return (IEnumerable) Activator.CreateInstance(typeof (EnumerableExtensions.GenericEnumerable<>).MakeGenericType(type), (object) source);
    }

    public static int IndexOf(this IEnumerable source, object item)
    {
      int num = 0;
      foreach (object objA in source)
      {
        if (object.Equals(objA, item))
          return num;
        ++num;
      }
      return -1;
    }

    internal static object ElementAt(this IEnumerable source, int index)
    {
      if (index < 0)
        throw new ArgumentOutOfRangeException(nameof (index));
      if (source is IList list && list.Count > 0)
        return list[index];
      foreach (object obj in source)
      {
        if (index == 0)
          return obj;
        --index;
      }
      return (object) null;
    }

    public static IEnumerable<TSource> SelectRecursive<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, IEnumerable<TSource>> recursiveSelector)
    {
      Stack<IEnumerator<TSource>> stack = new Stack<IEnumerator<TSource>>();
      stack.Push(source.GetEnumerator());
      try
      {
        while (stack.Count > 0)
        {
          if (stack.Peek().MoveNext())
          {
            TSource current = stack.Peek().Current;
            yield return current;
            IEnumerable<TSource> sources = recursiveSelector(current);
            if (sources != null)
              stack.Push(sources.GetEnumerator());
            current = default (TSource);
          }
          else
            stack.Pop().Dispose();
        }
      }
      finally
      {
        while (stack.Count > 0)
          stack.Pop().Dispose();
      }
    }

    internal static IEnumerable<TResult> Consolidate<TFirst, TSecond, TResult>(
      this IEnumerable<TFirst> first,
      IEnumerable<TSecond> second,
      Func<TFirst, TSecond, TResult> resultSelector)
    {
      if (first == null)
        throw new ArgumentNullException(nameof (first));
      if (second == null)
        throw new ArgumentNullException(nameof (second));
      if (resultSelector == null)
        throw new ArgumentNullException(nameof (resultSelector));
      return EnumerableExtensions.ZipIterator<TFirst, TSecond, TResult>(first, second, resultSelector);
    }

    private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(
      IEnumerable<TFirst> first,
      IEnumerable<TSecond> second,
      Func<TFirst, TSecond, TResult> resultSelector)
    {
      using (IEnumerator<TFirst> e1 = first.GetEnumerator())
      {
        using (IEnumerator<TSecond> e2 = second.GetEnumerator())
        {
          while (e1.MoveNext() && e2.MoveNext())
            yield return resultSelector(e1.Current, e2.Current);
        }
      }
    }

    public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(
      this IEnumerable<T> sequence)
    {
      if (sequence == null)
        return EnumerableExtensions.DefaultReadOnlyCollection<T>.Empty;
      return sequence is ReadOnlyCollection<T> readOnlyCollection ? readOnlyCollection : new ReadOnlyCollection<T>((IList<T>) sequence.ToArray<T>());
    }

    private class GenericEnumerable<T> : IEnumerable<T>, IEnumerable
    {
      private readonly IEnumerable source;

      public GenericEnumerable(IEnumerable source) => this.source = source;

      IEnumerator IEnumerable.GetEnumerator() => this.source.GetEnumerator();

      IEnumerator<T> IEnumerable<T>.GetEnumerator()
      {
        foreach (T obj in this.source)
          yield return obj;
      }
    }

    private static class DefaultReadOnlyCollection<T>
    {
      private static ReadOnlyCollection<T> defaultCollection;

      internal static ReadOnlyCollection<T> Empty
      {
        get
        {
          if (EnumerableExtensions.DefaultReadOnlyCollection<T>.defaultCollection == null)
            EnumerableExtensions.DefaultReadOnlyCollection<T>.defaultCollection = new ReadOnlyCollection<T>((IList<T>) new T[0]);
          return EnumerableExtensions.DefaultReadOnlyCollection<T>.defaultCollection;
        }
      }
    }
  }
}
