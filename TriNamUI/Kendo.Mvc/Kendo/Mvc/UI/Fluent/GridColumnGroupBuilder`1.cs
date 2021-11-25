// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridColumnGroupBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridColumnGroupBuilder<T> : 
    GridColumnBuilderBase<IGridColumnGroup, GridColumnGroupBuilder<T>>
    where T : class
  {
    private IUrlGenerator urlGenerator;
    private ViewContext viewContext;

    public new IGridColumnGroup Column { get; private set; }

    public GridColumnGroupBuilder(
      IGridColumnGroup column,
      Grid<T> container,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(column)
    {
      this.Column = column;
      this.Container = container;
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
    }

    public Grid<T> Container { get; private set; }

    public new GridColumnGroupBuilder<T> Title(string text)
    {
      this.Column.Title = text;
      return this;
    }

    public new GridColumnGroupBuilder<T> HeaderHtmlAttributes(
      object attributes)
    {
      return this.HeaderHtmlAttributes(attributes.ToDictionary());
    }

    public new GridColumnGroupBuilder<T> HeaderHtmlAttributes(
      IDictionary<string, object> attributes)
    {
      GridColumnGroupBuilder<T>.MergeAttributes(this.Column.HeaderHtmlAttributes, attributes);
      return this;
    }

    public new GridColumnGroupBuilder<T> Visible(bool value)
    {
      this.Column.Visible = value;
      return this;
    }

    public new GridColumnGroupBuilder<T> Locked() => this.Locked(true);

    public new GridColumnGroupBuilder<T> Locked(bool value)
    {
      this.Column.Locked = value;
      return this;
    }

    public new GridColumnGroupBuilder<T> Lockable(bool value)
    {
      this.Column.Lockable = value;
      return this;
    }

    public new GridColumnGroupBuilder<T> Sticky() => this.Sticky(true);

    public new GridColumnGroupBuilder<T> Sticky(bool value)
    {
      this.Column.Sticky = value;
      return this;
    }

    public new GridColumnGroupBuilder<T> Stickable() => this.Stickable(true);

    public new GridColumnGroupBuilder<T> Stickable(bool value)
    {
      this.Column.Stickable = value;
      return this;
    }

    public new GridColumnGroupBuilder<T> Hidden(bool value)
    {
      this.Column.Hidden = value;
      return this;
    }

    public new GridColumnGroupBuilder<T> Hidden()
    {
      this.Column.Hidden = true;
      return this;
    }

    public GridColumnGroupBuilder<T> Columns(
      Action<GridColumnFactory<T>> configurator)
    {
      GridColumnFactory<T> gridColumnFactory = new GridColumnFactory<T>(this.Container, this.viewContext, this.urlGenerator, (IGridColumnContainer<T>) this.Column);
      configurator(gridColumnFactory);
      return this;
    }

    private new static void MergeAttributes(
      IDictionary<string, object> target,
      IDictionary<string, object> attributes)
    {
      DictionaryExtensions.Merge(target, attributes);
    }
  }
}
