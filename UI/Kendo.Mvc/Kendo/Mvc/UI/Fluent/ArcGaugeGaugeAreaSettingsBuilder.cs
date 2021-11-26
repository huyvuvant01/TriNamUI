// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ArcGaugeGaugeAreaSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ArcGaugeGaugeAreaSettingsBuilder
  {
    public ArcGaugeGaugeAreaSettingsBuilder(ArcGaugeGaugeAreaSettings container) => this.Container = container;

    protected ArcGaugeGaugeAreaSettings Container { get; private set; }

    public ArcGaugeGaugeAreaSettingsBuilder Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ArcGaugeGaugeAreaSettingsBuilder Border(
      Action<ArcGaugeGaugeAreaBorderSettingsBuilder> configurator)
    {
      this.Container.Border.ArcGauge = this.Container.ArcGauge;
      configurator(new ArcGaugeGaugeAreaBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public ArcGaugeGaugeAreaSettingsBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public ArcGaugeGaugeAreaSettingsBuilder Margin(
      Action<ArcGaugeGaugeAreaMarginSettingsBuilder> configurator)
    {
      this.Container.Margin.ArcGauge = this.Container.ArcGauge;
      configurator(new ArcGaugeGaugeAreaMarginSettingsBuilder(this.Container.Margin));
      return this;
    }

    public ArcGaugeGaugeAreaSettingsBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
