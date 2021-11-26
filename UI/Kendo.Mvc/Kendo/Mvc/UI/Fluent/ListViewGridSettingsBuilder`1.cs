// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListViewGridSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ListViewGridSettingsBuilder<T> where T : class
  {
    public ListViewGridSettingsBuilder(ListViewGridSettings<T> container) => this.Container = container;

    protected ListViewGridSettings<T> Container { get; private set; }

    public ListViewGridSettingsBuilder<T> Cols(double value)
    {
      this.Container.Cols = new double?(value);
      return this;
    }

    public ListViewGridSettingsBuilder<T> Rows(double value)
    {
      this.Container.Rows = new double?(value);
      return this;
    }

    public ListViewGridSettingsBuilder<T> Gutter(double value)
    {
      this.Container.Gutter = new double?(value);
      return this;
    }
  }
}
