// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceFilterCompositeBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceFilterCompositeBuilder<TBuilder> : DataSourceFilterCompositeBuilderBase
    where TBuilder : DataSourceFilterDescriptorBuilderBase
  {
    public DataSourceFilterCompositeBuilder(CompositeFilterDescriptor descriptor)
      : base(descriptor)
    {
    }

    public virtual TBuilder And()
    {
      if (!(this.Descriptor.FilterDescriptors[this.Descriptor.FilterDescriptors.Count - 1] is FilterDescriptor filterDescriptor1))
        throw new InvalidCastException();
      FilterDescriptor filterDescriptor2 = new FilterDescriptor()
      {
        Member = filterDescriptor1.Member
      };
      this.Descriptor.LogicalOperator = FilterCompositionLogicalOperator.And;
      this.Descriptor.FilterDescriptors.Add((IFilterDescriptor) filterDescriptor2);
      return (TBuilder) Activator.CreateInstance(typeof (TBuilder), (object) this.Descriptor);
    }

    public virtual TBuilder Or()
    {
      if (!(this.Descriptor.FilterDescriptors[this.Descriptor.FilterDescriptors.Count - 1] is FilterDescriptor filterDescriptor1))
        throw new InvalidCastException();
      FilterDescriptor filterDescriptor2 = new FilterDescriptor()
      {
        Member = filterDescriptor1.Member
      };
      this.Descriptor.LogicalOperator = FilterCompositionLogicalOperator.Or;
      this.Descriptor.FilterDescriptors.Add((IFilterDescriptor) filterDescriptor2);
      return (TBuilder) Activator.CreateInstance(typeof (TBuilder), (object) this.Descriptor);
    }
  }
}
