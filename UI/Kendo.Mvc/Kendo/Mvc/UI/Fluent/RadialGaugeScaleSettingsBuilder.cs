// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadialGaugeScaleSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class RadialGaugeScaleSettingsBuilder
  {
    public RadialGaugeScaleSettingsBuilder(RadialGaugeScaleSettings container) => this.Container = container;

    protected RadialGaugeScaleSettings Container { get; private set; }

    public RadialGaugeScaleSettingsBuilder EndAngle(double value)
    {
      this.Container.EndAngle = new double?(value);
      return this;
    }

    public RadialGaugeScaleSettingsBuilder Labels(
      Action<RadialGaugeScaleLabelsSettingsBuilder> configurator)
    {
      this.Container.Labels.RadialGauge = this.Container.RadialGauge;
      configurator(new RadialGaugeScaleLabelsSettingsBuilder(this.Container.Labels));
      return this;
    }

    public RadialGaugeScaleSettingsBuilder MajorTicks(
      Action<RadialGaugeScaleMajorTicksSettingsBuilder> configurator)
    {
      this.Container.MajorTicks.RadialGauge = this.Container.RadialGauge;
      configurator(new RadialGaugeScaleMajorTicksSettingsBuilder(this.Container.MajorTicks));
      return this;
    }

    public RadialGaugeScaleSettingsBuilder MajorUnit(double value)
    {
      this.Container.MajorUnit = new double?(value);
      return this;
    }

    public RadialGaugeScaleSettingsBuilder Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public RadialGaugeScaleSettingsBuilder Min(double value)
    {
      this.Container.Min = new double?(value);
      return this;
    }

    public RadialGaugeScaleSettingsBuilder MinorTicks(
      Action<RadialGaugeScaleMinorTicksSettingsBuilder> configurator)
    {
      this.Container.MinorTicks.RadialGauge = this.Container.RadialGauge;
      configurator(new RadialGaugeScaleMinorTicksSettingsBuilder(this.Container.MinorTicks));
      return this;
    }

    public RadialGaugeScaleSettingsBuilder MinorUnit(double value)
    {
      this.Container.MinorUnit = new double?(value);
      return this;
    }

    public RadialGaugeScaleSettingsBuilder Ranges(
      Action<RadialGaugeScaleSettingsRangeFactory> configurator)
    {
      configurator(new RadialGaugeScaleSettingsRangeFactory(this.Container.Ranges)
      {
        RadialGauge = this.Container.RadialGauge
      });
      return this;
    }

    public RadialGaugeScaleSettingsBuilder RangePlaceholderColor(
      string value)
    {
      this.Container.RangePlaceholderColor = value;
      return this;
    }

    public RadialGaugeScaleSettingsBuilder RangeSize(double value)
    {
      this.Container.RangeSize = new double?(value);
      return this;
    }

    public RadialGaugeScaleSettingsBuilder RangeDistance(double value)
    {
      this.Container.RangeDistance = new double?(value);
      return this;
    }

    public RadialGaugeScaleSettingsBuilder Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public RadialGaugeScaleSettingsBuilder Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public RadialGaugeScaleSettingsBuilder StartAngle(double value)
    {
      this.Container.StartAngle = new double?(value);
      return this;
    }
  }
}
