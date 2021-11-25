// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisLabelsRotationSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisLabelsRotationSettingsBuilder<T> where T : class
  {
    public ChartCategoryAxisLabelsRotationSettingsBuilder(
      ChartCategoryAxisLabelsRotationSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartCategoryAxisLabelsRotationSettings<T> Container { get; private set; }

    public ChartCategoryAxisLabelsRotationSettingsBuilder<T> Angle(
      object value)
    {
      this.Container.Angle = value;
      return this;
    }

    public ChartCategoryAxisLabelsRotationSettingsBuilder<T> Align(
      ChartAxisLabelRotationAlignment value)
    {
      this.Container.Align = new ChartAxisLabelRotationAlignment?(value);
      return this;
    }
  }
}
