// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListColumnGroupBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListColumnGroupBuilder<T> where T : class
  {
    public TreeListColumnGroup<T> Column { get; private set; }

    public TreeListColumnGroupBuilder(TreeListColumnGroup<T> column) => this.Column = column;

    public TreeListColumnGroupBuilder<T> Title(string text)
    {
      this.Column.Title = text;
      return this;
    }

    public TreeListColumnGroupBuilder<T> HeaderHtmlAttributes(
      object attributes)
    {
      return this.HeaderHtmlAttributes(attributes.ToDictionary());
    }

    public TreeListColumnGroupBuilder<T> HeaderHtmlAttributes(
      IDictionary<string, object> attributes)
    {
      TreeListColumnGroupBuilder<T>.MergeAttributes(this.Column.HeaderAttributes, attributes);
      return this;
    }

    public TreeListColumnGroupBuilder<T> Locked() => this.Locked(true);

    public TreeListColumnGroupBuilder<T> Locked(bool value)
    {
      this.Column.Locked = new bool?(value);
      return this;
    }

    public TreeListColumnGroupBuilder<T> Lockable(bool value)
    {
      this.Column.Lockable = new bool?(value);
      return this;
    }

    public TreeListColumnGroupBuilder<T> Hidden(bool value)
    {
      this.Column.Hidden = new bool?(value);
      return this;
    }

    public TreeListColumnGroupBuilder<T> Hidden()
    {
      this.Column.Hidden = new bool?(true);
      return this;
    }

    public TreeListColumnGroupBuilder<T> Columns(
      Action<TreeListColumnFactory<T>> configurator)
    {
      TreeListColumnFactory<T> listColumnFactory = new TreeListColumnFactory<T>(this.Column)
      {
        TreeList = this.Column.TreeList
      };
      configurator(listColumnFactory);
      return this;
    }

    public TreeListColumnGroupBuilder<T> HeaderTemplate(string template)
    {
      this.Column.HeaderTemplate = template;
      return this;
    }

    private static void MergeAttributes(
      IDictionary<string, object> target,
      IDictionary<string, object> attributes)
    {
      DictionaryExtensions.Merge(target, attributes);
    }
  }
}
