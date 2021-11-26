// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisRangeLabelsRotationSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisRangeLabelsRotationSettingsBuilder<T> where T : class
  {
    public ChartCategoryAxisRangeLabelsRotationSettingsBuilder(
      ChartCategoryAxisRangeLabelsRotationSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartCategoryAxisRangeLabelsRotationSettings<T> Container { get; private set; }

    public ChartCategoryAxisRangeLabelsRotationSettingsBuilder<T> Align(
      string value)
    {
      this.Container.Align = value;
      return this;
    }

    public ChartCategoryAxisRangeLabelsRotationSettingsBuilder<T> Angle(
      double value)
    {
      this.Container.Angle = new double?(value);
      return this;
    }
  }
}
