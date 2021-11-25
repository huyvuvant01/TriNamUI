// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListViewFlexSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ListViewFlexSettingsBuilder<T> where T : class
  {
    public ListViewFlexSettingsBuilder(ListViewFlexSettings<T> container) => this.Container = container;

    protected ListViewFlexSettings<T> Container { get; private set; }

    public ListViewFlexSettingsBuilder<T> Direction(string value)
    {
      this.Container.Direction = value;
      return this;
    }

    public ListViewFlexSettingsBuilder<T> Wrap(string value)
    {
      this.Container.Wrap = value;
      return this;
    }
  }
}
