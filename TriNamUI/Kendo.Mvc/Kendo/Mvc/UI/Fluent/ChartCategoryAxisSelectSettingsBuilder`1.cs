// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisSelectSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisSelectSettingsBuilder<T> where T : class
  {
    public ChartCategoryAxisSelectSettingsBuilder(ChartCategoryAxisSelectSettings<T> container) => this.Container = container;

    protected ChartCategoryAxisSelectSettings<T> Container { get; private set; }

    public ChartCategoryAxisSelectSettingsBuilder<T> From(
      object value)
    {
      this.Container.From = value;
      return this;
    }

    public ChartCategoryAxisSelectSettingsBuilder<T> Max(
      object value)
    {
      this.Container.Max = value;
      return this;
    }

    public ChartCategoryAxisSelectSettingsBuilder<T> Min(
      object value)
    {
      this.Container.Min = value;
      return this;
    }

    public ChartCategoryAxisSelectSettingsBuilder<T> Mousewheel(
      Action<ChartCategoryAxisSelectMousewheelSettingsBuilder<T>> configurator)
    {
      this.Container.Mousewheel.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisSelectMousewheelSettingsBuilder<T>(this.Container.Mousewheel));
      return this;
    }

    public ChartCategoryAxisSelectSettingsBuilder<T> To(
      object value)
    {
      this.Container.To = value;
      return this;
    }
  }
}
