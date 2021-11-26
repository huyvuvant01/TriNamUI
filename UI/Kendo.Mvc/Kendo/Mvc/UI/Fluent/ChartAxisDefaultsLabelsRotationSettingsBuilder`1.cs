// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartAxisDefaultsLabelsRotationSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartAxisDefaultsLabelsRotationSettingsBuilder<T> where T : class
  {
    public ChartAxisDefaultsLabelsRotationSettingsBuilder(
      ChartAxisDefaultsLabelsRotationSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartAxisDefaultsLabelsRotationSettings<T> Container { get; private set; }

    public ChartAxisDefaultsLabelsRotationSettingsBuilder<T> Angle(
      double value)
    {
      this.Container.Angle = new double?(value);
      return this;
    }

    public ChartAxisDefaultsLabelsRotationSettingsBuilder<T> Align(
      ChartAxisLabelRotationAlignment value)
    {
      this.Container.Align = new ChartAxisLabelRotationAlignment?(value);
      return this;
    }
  }
}
