// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceSortDescriptorBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceSortDescriptorBuilder
  {
    public DataSourceSortDescriptorBuilder(SortDescriptor descriptor) => this.Descriptor = descriptor;

    protected SortDescriptor Descriptor { get; private set; }

    public virtual void Ascending() => this.Descriptor.SortDirection = ListSortDirection.Ascending;

    public virtual void Descending() => this.Descriptor.SortDirection = ListSortDirection.Descending;

    public virtual void Order(ListSortDirection direction) => this.Descriptor.SortDirection = direction;
  }
}
