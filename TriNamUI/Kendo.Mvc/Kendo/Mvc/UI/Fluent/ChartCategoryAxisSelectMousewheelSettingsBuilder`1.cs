// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisSelectMousewheelSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisSelectMousewheelSettingsBuilder<T> where T : class
  {
    public ChartCategoryAxisSelectMousewheelSettingsBuilder(
      ChartCategoryAxisSelectMousewheelSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartCategoryAxisSelectMousewheelSettings<T> Container { get; private set; }

    public ChartCategoryAxisSelectMousewheelSettingsBuilder<T> Reverse(
      bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public ChartCategoryAxisSelectMousewheelSettingsBuilder<T> Zoom(
      ChartZoomDirection value)
    {
      this.Container.Zoom = new ChartZoomDirection?(value);
      return this;
    }
  }
}
