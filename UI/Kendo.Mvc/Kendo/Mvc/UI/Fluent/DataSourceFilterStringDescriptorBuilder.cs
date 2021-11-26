// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceFilterStringDescriptorBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceFilterStringDescriptorBuilder : 
    DataSourceFilterEqualityDescriptorBuilderBase<string, DataSourceFilterCompositeBuilder<DataSourceFilterStringDescriptorBuilder>>
  {
    public DataSourceFilterStringDescriptorBuilder(CompositeFilterDescriptor descriptor)
      : base(descriptor)
    {
    }

    public DataSourceFilterCompositeBuilder<DataSourceFilterStringDescriptorBuilder> StartsWith(
      string value)
    {
      this.SetOperatorAndValue(FilterOperator.StartsWith, (object) value);
      return this.CreateBuilder();
    }

    public DataSourceFilterCompositeBuilder<DataSourceFilterStringDescriptorBuilder> EndsWith(
      string value)
    {
      this.SetOperatorAndValue(FilterOperator.EndsWith, (object) value);
      return this.CreateBuilder();
    }

    public DataSourceFilterCompositeBuilder<DataSourceFilterStringDescriptorBuilder> Contains(
      string value)
    {
      this.SetOperatorAndValue(FilterOperator.Contains, (object) value);
      return this.CreateBuilder();
    }

    public DataSourceFilterCompositeBuilder<DataSourceFilterStringDescriptorBuilder> DoesNotContain(
      string value)
    {
      this.SetOperatorAndValue(FilterOperator.DoesNotContain, (object) value);
      return this.CreateBuilder();
    }

    public DataSourceFilterCompositeBuilder<DataSourceFilterStringDescriptorBuilder> IsEmpty()
    {
      this.SetOperatorAndValue(FilterOperator.IsEmpty, (object) string.Empty);
      return this.CreateBuilder();
    }

    public DataSourceFilterCompositeBuilder<DataSourceFilterStringDescriptorBuilder> IsNotEmpty()
    {
      this.SetOperatorAndValue(FilterOperator.IsNotEmpty, (object) string.Empty);
      return this.CreateBuilder();
    }
  }
}
