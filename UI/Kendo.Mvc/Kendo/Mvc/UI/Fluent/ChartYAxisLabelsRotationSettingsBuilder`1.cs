// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartYAxisLabelsRotationSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartYAxisLabelsRotationSettingsBuilder<T> where T : class
  {
    public ChartYAxisLabelsRotationSettingsBuilder(ChartYAxisLabelsRotationSettings<T> container) => this.Container = container;

    protected ChartYAxisLabelsRotationSettings<T> Container { get; private set; }

    public ChartYAxisLabelsRotationSettingsBuilder<T> Align(
      string value)
    {
      this.Container.Align = value;
      return this;
    }

    public ChartYAxisLabelsRotationSettingsBuilder<T> Angle(
      double value)
    {
      this.Container.Angle = new double?(value);
      return this;
    }
  }
}
