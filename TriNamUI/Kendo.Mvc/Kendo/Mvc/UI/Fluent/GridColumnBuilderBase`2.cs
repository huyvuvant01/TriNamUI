// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridColumnBuilderBase`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class GridColumnBuilderBase<TColumn, TColumnBuilder> : IHideObjectMembers
    where TColumn : IGridColumn
    where TColumnBuilder : GridColumnBuilderBase<TColumn, TColumnBuilder>
  {
    protected GridColumnBuilderBase(TColumn column) => this.Column = column;

    public TColumn Column { get; private set; }

    public TColumnBuilder Title(string text)
    {
      this.Column.Title = text;
      return this as TColumnBuilder;
    }

    public TColumnBuilder HeaderHtmlAttributes(object attributes) => this.HeaderHtmlAttributes(attributes.ToDictionary());

    public TColumnBuilder HeaderHtmlAttributes(IDictionary<string, object> attributes)
    {
      GridColumnBuilderBase<TColumn, TColumnBuilder>.MergeAttributes(this.Column.HeaderHtmlAttributes, attributes);
      return this as TColumnBuilder;
    }

    public TColumnBuilder HtmlAttributes(object attributes) => this.HtmlAttributes(attributes.ToDictionary());

    public TColumnBuilder HtmlAttributes(IDictionary<string, object> attributes)
    {
      GridColumnBuilderBase<TColumn, TColumnBuilder>.MergeAttributes(this.Column.HtmlAttributes, attributes);
      return this as TColumnBuilder;
    }

    public TColumnBuilder Media(string value)
    {
      this.Column.Media = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder MinScreenWidth(int value)
    {
      this.Column.MinScreenWidth = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder MinResizableWidth(int value)
    {
      this.Column.MinResizableWidth = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder Width(int pixelWidth)
    {
      this.Column.Width = pixelWidth.ToString() + "px";
      return this as TColumnBuilder;
    }

    public TColumnBuilder Width(string value)
    {
      this.Column.Width = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder Visible(bool value)
    {
      this.Column.Visible = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder Locked() => this.Locked(true);

    public TColumnBuilder Locked(bool value)
    {
      this.Column.Locked = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder Lockable(bool value)
    {
      this.Column.Lockable = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder Sticky() => this.Sticky(true);

    public TColumnBuilder Sticky(bool value)
    {
      this.Column.Sticky = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder Stickable() => this.Stickable(true);

    public TColumnBuilder Stickable(bool value)
    {
      this.Column.Stickable = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder Hidden(bool value)
    {
      this.Column.Hidden = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder Hidden()
    {
      this.Column.Hidden = true;
      return this as TColumnBuilder;
    }

    public TColumnBuilder Exportable(bool value)
    {
      this.Column.Exportable.Enabled = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder Exportable(Action<GridColumnExportableBuilder> configurator)
    {
      configurator(new GridColumnExportableBuilder(this.Column.Exportable));
      return this as TColumnBuilder;
    }

    protected static void MergeAttributes(
      IDictionary<string, object> target,
      IDictionary<string, object> attributes)
    {
      DictionaryExtensions.Merge(target, attributes);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
