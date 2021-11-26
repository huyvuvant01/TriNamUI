// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListSortableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListSortableSettingsBuilder<T> where T : class
  {
    public TreeListSortableSettingsBuilder(TreeListSortableSettings<T> container) => this.Container = container;

    protected TreeListSortableSettings<T> Container { get; private set; }

    public TreeListSortableSettingsBuilder<T> Mode(string value)
    {
      this.Container.Mode = new TreeListSortMode?(value == "single" ? TreeListSortMode.SingleColumn : TreeListSortMode.MultipleColumn);
      return this;
    }

    public TreeListSortableSettingsBuilder<T> AllowUnsort(bool value)
    {
      this.Container.AllowUnsort = new bool?(value);
      return this;
    }

    public TreeListSortableSettingsBuilder<T> Mode(
      TreeListSortMode value)
    {
      this.Container.Mode = new TreeListSortMode?(value);
      return this;
    }
  }
}
