// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotAjaxDataSourceSchemaCubeMeasureBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotAjaxDataSourceSchemaCubeMeasureBuilder<TModel> where TModel : class
  {
    protected readonly PivotDataSourceSchemaMeasureDescriptor measure;

    public PivotAjaxDataSourceSchemaCubeMeasureBuilder(
      PivotDataSourceSchemaMeasureDescriptor measure)
    {
      this.measure = measure;
    }

    public PivotAjaxDataSourceSchemaCubeMeasureBuilder<TModel> Field<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      this.measure.Field = expression.MemberWithoutInstance();
      return this;
    }

    public PivotAjaxDataSourceSchemaCubeMeasureBuilder<TModel> Field(
      string member)
    {
      this.measure.Field = member;
      return this;
    }

    public PivotAjaxDataSourceSchemaCubeMeasureBuilder<TModel> Caption(
      string caption)
    {
      this.measure.Caption = caption;
      return this;
    }

    public PivotAjaxDataSourceSchemaCubeMeasureBuilder<TModel> Format(
      string format)
    {
      this.measure.Format = format;
      return this;
    }

    public virtual PivotAjaxDataSourceSchemaCubeMeasureBuilder<TModel> Aggregate(
      string aggregate)
    {
      this.measure.Aggregate.HandlerName = aggregate;
      return this;
    }

    public virtual PivotAjaxDataSourceSchemaCubeMeasureBuilder<TModel> Aggregate(
      Func<object, object> handler)
    {
      this.measure.Aggregate.TemplateDelegate = handler;
      return this;
    }

    public virtual PivotAjaxDataSourceSchemaCubeMeasureBuilder<TModel> AggregateName(
      string aggregateName)
    {
      this.measure.AggregateName = aggregateName;
      return this;
    }

    public virtual PivotAjaxDataSourceSchemaCubeMeasureBuilder<TModel> Result(
      string result)
    {
      this.measure.Result.HandlerName = result;
      return this;
    }

    public virtual PivotAjaxDataSourceSchemaCubeMeasureBuilder<TModel> Result(
      Func<object, object> handler)
    {
      this.measure.Result.TemplateDelegate = handler;
      return this;
    }
  }
}
