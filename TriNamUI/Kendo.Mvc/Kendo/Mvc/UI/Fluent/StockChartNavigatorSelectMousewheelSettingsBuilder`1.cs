// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorSelectMousewheelSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorSelectMousewheelSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorSelectMousewheelSettingsBuilder(
      StockChartNavigatorSelectMousewheelSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorSelectMousewheelSettings<T> Container { get; private set; }

    public StockChartNavigatorSelectMousewheelSettingsBuilder<T> Reverse(
      bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public StockChartNavigatorSelectMousewheelSettingsBuilder<T> Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public StockChartNavigatorSelectMousewheelSettingsBuilder<T> Zoom(
      string value)
    {
      this.Container.Zoom = value;
      return this;
    }
  }
}
