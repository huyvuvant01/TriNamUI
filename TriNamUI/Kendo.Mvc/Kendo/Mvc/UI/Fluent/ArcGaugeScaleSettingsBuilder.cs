// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ArcGaugeScaleSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ArcGaugeScaleSettingsBuilder
  {
    public ArcGaugeScaleSettingsBuilder(ArcGaugeScaleSettings container) => this.Container = container;

    protected ArcGaugeScaleSettings Container { get; private set; }

    public ArcGaugeScaleSettingsBuilder EndAngle(double value)
    {
      this.Container.EndAngle = new double?(value);
      return this;
    }

    public ArcGaugeScaleSettingsBuilder Labels(
      Action<ArcGaugeScaleLabelsSettingsBuilder> configurator)
    {
      this.Container.Labels.ArcGauge = this.Container.ArcGauge;
      configurator(new ArcGaugeScaleLabelsSettingsBuilder(this.Container.Labels));
      return this;
    }

    public ArcGaugeScaleSettingsBuilder MajorTicks(
      Action<ArcGaugeScaleMajorTicksSettingsBuilder> configurator)
    {
      this.Container.MajorTicks.ArcGauge = this.Container.ArcGauge;
      configurator(new ArcGaugeScaleMajorTicksSettingsBuilder(this.Container.MajorTicks));
      return this;
    }

    public ArcGaugeScaleSettingsBuilder MajorUnit(double value)
    {
      this.Container.MajorUnit = new double?(value);
      return this;
    }

    public ArcGaugeScaleSettingsBuilder Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public ArcGaugeScaleSettingsBuilder Min(double value)
    {
      this.Container.Min = new double?(value);
      return this;
    }

    public ArcGaugeScaleSettingsBuilder MinorTicks(
      Action<ArcGaugeScaleMinorTicksSettingsBuilder> configurator)
    {
      this.Container.MinorTicks.ArcGauge = this.Container.ArcGauge;
      configurator(new ArcGaugeScaleMinorTicksSettingsBuilder(this.Container.MinorTicks));
      return this;
    }

    public ArcGaugeScaleSettingsBuilder MinorUnit(double value)
    {
      this.Container.MinorUnit = new double?(value);
      return this;
    }

    public ArcGaugeScaleSettingsBuilder RangeLineCap(string value)
    {
      this.Container.RangeLineCap = value;
      return this;
    }

    public ArcGaugeScaleSettingsBuilder RangePlaceholderColor(
      string value)
    {
      this.Container.RangePlaceholderColor = value;
      return this;
    }

    public ArcGaugeScaleSettingsBuilder RangeSize(double value)
    {
      this.Container.RangeSize = new double?(value);
      return this;
    }

    public ArcGaugeScaleSettingsBuilder RangeDistance(double value)
    {
      this.Container.RangeDistance = new double?(value);
      return this;
    }

    public ArcGaugeScaleSettingsBuilder Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public ArcGaugeScaleSettingsBuilder Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public ArcGaugeScaleSettingsBuilder StartAngle(double value)
    {
      this.Container.StartAngle = new double?(value);
      return this;
    }
  }
}
