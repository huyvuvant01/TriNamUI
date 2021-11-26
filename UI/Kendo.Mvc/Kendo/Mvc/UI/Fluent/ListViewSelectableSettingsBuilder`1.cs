// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListViewSelectableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ListViewSelectableSettingsBuilder<T> where T : class
  {
    public ListViewSelectableSettingsBuilder(ListViewSelectableSettings<T> container) => this.Container = container;

    protected ListViewSelectableSettings<T> Container { get; private set; }

    public ListViewSelectableSettingsBuilder<T> Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      if (!this.Container.Mode.HasValue)
        this.Container.Mode = new ListViewSelectionMode?(ListViewSelectionMode.Single);
      return this;
    }

    public ListViewSelectableSettingsBuilder<T> Mode(
      ListViewSelectionMode value)
    {
      this.Container.Mode = new ListViewSelectionMode?(value);
      return this;
    }
  }
}
