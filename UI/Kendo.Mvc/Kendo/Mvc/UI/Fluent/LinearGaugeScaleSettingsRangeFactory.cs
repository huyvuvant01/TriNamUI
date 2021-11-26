// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.LinearGaugeScaleSettingsRangeFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class LinearGaugeScaleSettingsRangeFactory
  {
    public LinearGaugeScaleSettingsRangeFactory(List<LinearGaugeScaleSettingsRange> container) => this.Container = container;

    protected List<LinearGaugeScaleSettingsRange> Container { get; private set; }

    public virtual LinearGaugeScaleSettingsRangeBuilder Add(
      double from,
      double to,
      string color)
    {
      LinearGaugeScaleSettingsRange container = new LinearGaugeScaleSettingsRange();
      container.LinearGauge = this.LinearGauge;
      container.From = new double?(from);
      container.To = new double?(to);
      container.Color = color;
      this.Container.Add(container);
      return new LinearGaugeScaleSettingsRangeBuilder(container);
    }

    public LinearGauge LinearGauge { get; set; }

    public virtual LinearGaugeScaleSettingsRangeBuilder Add()
    {
      LinearGaugeScaleSettingsRange container = new LinearGaugeScaleSettingsRange();
      container.LinearGauge = this.LinearGauge;
      this.Container.Add(container);
      return new LinearGaugeScaleSettingsRangeBuilder(container);
    }
  }
}
