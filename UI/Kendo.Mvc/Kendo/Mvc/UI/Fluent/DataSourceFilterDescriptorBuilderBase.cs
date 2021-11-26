// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceFilterDescriptorBuilderBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class DataSourceFilterDescriptorBuilderBase : IHideObjectMembers
  {
    protected DataSourceFilterDescriptorBuilderBase(CompositeFilterDescriptor descriptor) => this.Descriptor = descriptor;

    protected CompositeFilterDescriptor Descriptor { get; private set; }

    protected virtual void SetOperatorAndValue(FilterOperator filterOperator, object value)
    {
      if (!(this.Descriptor.FilterDescriptors[this.Descriptor.FilterDescriptors.Count - 1] is FilterDescriptor filterDescriptor))
        throw new InvalidCastException();
      filterDescriptor.Operator = filterOperator;
      filterDescriptor.Value = value;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
