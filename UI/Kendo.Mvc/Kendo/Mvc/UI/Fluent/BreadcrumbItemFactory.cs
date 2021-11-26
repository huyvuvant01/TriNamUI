// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.BreadcrumbItemFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class BreadcrumbItemFactory
  {
    public BreadcrumbItemFactory(List<BreadcrumbItem> container) => this.Container = container;

    protected List<BreadcrumbItem> Container { get; private set; }

    public Breadcrumb Breadcrumb { get; set; }

    public virtual BreadcrumbItemBuilder Add()
    {
      BreadcrumbItem container = new BreadcrumbItem();
      container.Breadcrumb = this.Breadcrumb;
      this.Container.Add(container);
      return new BreadcrumbItemBuilder(container);
    }
  }
}
