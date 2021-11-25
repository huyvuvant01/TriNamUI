// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListExcelSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListExcelSettingsBuilder<T> where T : class
  {
    public TreeListExcelSettingsBuilder(TreeListExcelSettings<T> container) => this.Container = container;

    protected TreeListExcelSettings<T> Container { get; private set; }

    public TreeListExcelSettingsBuilder<T> AllPages(bool value)
    {
      this.Container.AllPages = new bool?(value);
      return this;
    }

    public TreeListExcelSettingsBuilder<T> AllPages()
    {
      this.Container.AllPages = new bool?(true);
      return this;
    }

    public TreeListExcelSettingsBuilder<T> FileName(string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public TreeListExcelSettingsBuilder<T> Filterable(bool value)
    {
      this.Container.Filterable = new bool?(value);
      return this;
    }

    public TreeListExcelSettingsBuilder<T> Filterable()
    {
      this.Container.Filterable = new bool?(true);
      return this;
    }

    public TreeListExcelSettingsBuilder<T> ForceProxy(bool value)
    {
      this.Container.ForceProxy = new bool?(value);
      return this;
    }

    public TreeListExcelSettingsBuilder<T> ForceProxy()
    {
      this.Container.ForceProxy = new bool?(true);
      return this;
    }

    public TreeListExcelSettingsBuilder<T> ProxyURL(string value)
    {
      this.Container.ProxyURL = value;
      return this;
    }
  }
}
