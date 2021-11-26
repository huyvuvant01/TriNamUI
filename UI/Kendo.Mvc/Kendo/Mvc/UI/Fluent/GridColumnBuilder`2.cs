// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridColumnBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class GridColumnBuilder<TColumn, TColumnBuilder> : 
    GridColumnBuilderBase<TColumn, TColumnBuilder>
    where TColumn : IGridColumn
    where TColumnBuilder : GridColumnBuilder<TColumn, TColumnBuilder>
  {
    protected GridColumnBuilder(TColumn column)
      : base(column)
    {
    }

    public TColumnBuilder FooterHtmlAttributes(object attributes) => this.FooterHtmlAttributes(attributes.ToDictionary());

    public TColumnBuilder FooterHtmlAttributes(IDictionary<string, object> attributes)
    {
      GridColumnBuilderBase<TColumn, TColumnBuilder>.MergeAttributes(this.Column.FooterHtmlAttributes, attributes);
      return this as TColumnBuilder;
    }

    public TColumnBuilder IncludeInMenu(bool value)
    {
      this.Column.IncludeInMenu = value;
      return this as TColumnBuilder;
    }

    public TColumnBuilder ClientHeaderTemplate(string template)
    {
      this.Column.ClientHeaderTemplate = template;
      return this as TColumnBuilder;
    }

    public TColumnBuilder ClientFooterTemplate(string template)
    {
      this.Column.ClientFooterTemplate = template;
      return this as TColumnBuilder;
    }

    public TColumnBuilder ClientGroupFooterTemplate(string template)
    {
      this.Column.ClientGroupFooterTemplate = template;
      return this as TColumnBuilder;
    }
  }
}
