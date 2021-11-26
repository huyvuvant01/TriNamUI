// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListSelectableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListSelectableSettingsBuilder<T> where T : class
  {
    public TreeListSelectableSettingsBuilder(TreeListSelectableSettings<T> container) => this.Container = container;

    protected TreeListSelectableSettings<T> Container { get; private set; }

    public TreeListSelectableSettingsBuilder<T> Mode(
      TreeListSelectionMode value)
    {
      this.Container.Mode = new TreeListSelectionMode?(value);
      return this;
    }

    public TreeListSelectableSettingsBuilder<T> Type(
      TreeListSelectionType value)
    {
      this.Container.Type = new TreeListSelectionType?(value);
      return this;
    }
  }
}
