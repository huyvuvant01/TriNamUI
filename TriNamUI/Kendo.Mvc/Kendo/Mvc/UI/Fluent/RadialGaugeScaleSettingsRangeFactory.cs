// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadialGaugeScaleSettingsRangeFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class RadialGaugeScaleSettingsRangeFactory
  {
    public RadialGaugeScaleSettingsRangeFactory(List<RadialGaugeScaleSettingsRange> container) => this.Container = container;

    protected List<RadialGaugeScaleSettingsRange> Container { get; private set; }

    public virtual RadialGaugeScaleSettingsRangeBuilder Add(
      double from,
      double to,
      string color)
    {
      RadialGaugeScaleSettingsRange container = new RadialGaugeScaleSettingsRange();
      container.RadialGauge = this.RadialGauge;
      container.From = new double?(from);
      container.To = new double?(to);
      container.Color = color;
      this.Container.Add(container);
      return new RadialGaugeScaleSettingsRangeBuilder(container);
    }

    public RadialGauge RadialGauge { get; set; }

    public virtual RadialGaugeScaleSettingsRangeBuilder Add()
    {
      RadialGaugeScaleSettingsRange container = new RadialGaugeScaleSettingsRange();
      container.RadialGauge = this.RadialGauge;
      this.Container.Add(container);
      return new RadialGaugeScaleSettingsRangeBuilder(container);
    }
  }
}
