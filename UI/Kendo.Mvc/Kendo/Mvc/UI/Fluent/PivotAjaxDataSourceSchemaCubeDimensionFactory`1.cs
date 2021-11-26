// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotAjaxDataSourceSchemaCubeDimensionFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotAjaxDataSourceSchemaCubeDimensionFactory<TModel> where TModel : class
  {
    protected readonly IList<PivotDataSourceSchemaDimensionDescriptor> dimensions;

    public PivotAjaxDataSourceSchemaCubeDimensionFactory(
      IList<PivotDataSourceSchemaDimensionDescriptor> dimensions)
    {
      this.dimensions = dimensions;
    }

    public PivotAjaxDataSourceSchemaCubeDimensionBuilder Add(
      string member)
    {
      return this.AddDimensionDescriptor(member);
    }

    public PivotAjaxDataSourceSchemaCubeDimensionBuilder Add<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      return this.AddDimensionDescriptor(expression.MemberWithoutInstance());
    }

    private PivotAjaxDataSourceSchemaCubeDimensionBuilder AddDimensionDescriptor(
      string member)
    {
      PivotDataSourceSchemaDimensionDescriptor dimension = this.dimensions.FirstOrDefault<PivotDataSourceSchemaDimensionDescriptor>((Func<PivotDataSourceSchemaDimensionDescriptor, bool>) (f => f.Member == member));
      if (dimension == null)
        dimension = new PivotDataSourceSchemaDimensionDescriptor()
        {
          Member = member
        };
      this.dimensions.Add(dimension);
      return new PivotAjaxDataSourceSchemaCubeDimensionBuilder(dimension);
    }
  }
}
