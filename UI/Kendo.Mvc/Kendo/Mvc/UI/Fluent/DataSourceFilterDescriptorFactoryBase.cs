// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceFilterDescriptorFactoryBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class DataSourceFilterDescriptorFactoryBase
  {
    public DataSourceFilterDescriptorFactoryBase(IList<IFilterDescriptor> filters) => this.Filters = filters;

    protected IList<IFilterDescriptor> Filters { get; private set; }

    public virtual void AddRange(IEnumerable<IFilterDescriptor> filters)
    {
      foreach (IFilterDescriptor filter in filters)
      {
        if (!(filter is CompositeFilterDescriptor filterDescriptor2))
        {
          filterDescriptor2 = new CompositeFilterDescriptor()
          {
            LogicalOperator = FilterCompositionLogicalOperator.And
          };
          filterDescriptor2.FilterDescriptors.Add(filter);
        }
        this.Filters.Add((IFilterDescriptor) filterDescriptor2);
      }
    }
  }
}
