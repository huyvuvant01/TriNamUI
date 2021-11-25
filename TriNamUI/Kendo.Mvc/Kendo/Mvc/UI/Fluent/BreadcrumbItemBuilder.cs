// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.BreadcrumbItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class BreadcrumbItemBuilder
  {
    public BreadcrumbItemBuilder(BreadcrumbItem container) => this.Container = container;

    protected BreadcrumbItem Container { get; private set; }

    public BreadcrumbItemBuilder Href(string value)
    {
      this.Container.Href = value;
      return this;
    }

    public BreadcrumbItemBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public BreadcrumbItemBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public BreadcrumbItemBuilder ItemClass(string value)
    {
      this.Container.ItemClass = value;
      return this;
    }

    public BreadcrumbItemBuilder LinkClass(string value)
    {
      this.Container.LinkClass = value;
      return this;
    }

    public BreadcrumbItemBuilder IconClass(string value)
    {
      this.Container.IconClass = value;
      return this;
    }

    public BreadcrumbItemBuilder ShowIcon(bool value)
    {
      this.Container.ShowIcon = new bool?(value);
      return this;
    }

    public BreadcrumbItemBuilder ShowText(bool value)
    {
      this.Container.ShowText = new bool?(value);
      return this;
    }

    public BreadcrumbItemBuilder Type(BreadcrumbItemType value)
    {
      this.Container.Type = new BreadcrumbItemType?(value);
      return this;
    }
  }
}
