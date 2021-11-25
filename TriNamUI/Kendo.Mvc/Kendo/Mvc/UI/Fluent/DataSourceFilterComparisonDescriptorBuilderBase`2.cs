// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceFilterComparisonDescriptorBuilderBase`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class DataSourceFilterComparisonDescriptorBuilderBase<TValue, TCompositeBuilder> : 
    DataSourceFilterEqualityDescriptorBuilderBase<TValue, TCompositeBuilder>
    where TCompositeBuilder : DataSourceFilterCompositeBuilderBase
  {
    protected DataSourceFilterComparisonDescriptorBuilderBase(CompositeFilterDescriptor descriptor)
      : base(descriptor)
    {
    }

    public TCompositeBuilder IsLessThan(TValue value)
    {
      this.SetOperatorAndValue(FilterOperator.IsLessThan, (object) value);
      return this.CreateBuilder();
    }

    public TCompositeBuilder IsLessThanOrEqualTo(TValue value)
    {
      this.SetOperatorAndValue(FilterOperator.IsLessThanOrEqualTo, (object) value);
      return this.CreateBuilder();
    }

    public TCompositeBuilder IsGreaterThanOrEqualTo(TValue value)
    {
      this.SetOperatorAndValue(FilterOperator.IsGreaterThanOrEqualTo, (object) value);
      return this.CreateBuilder();
    }

    public TCompositeBuilder IsGreaterThan(TValue value)
    {
      this.SetOperatorAndValue(FilterOperator.IsGreaterThan, (object) value);
      return this.CreateBuilder();
    }
  }
}
