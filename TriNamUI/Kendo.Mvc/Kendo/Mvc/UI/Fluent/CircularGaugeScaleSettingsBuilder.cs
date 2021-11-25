// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CircularGaugeScaleSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CircularGaugeScaleSettingsBuilder
  {
    public CircularGaugeScaleSettingsBuilder(CircularGaugeScaleSettings container) => this.Container = container;

    protected CircularGaugeScaleSettings Container { get; private set; }

    public CircularGaugeScaleSettingsBuilder Labels(
      Action<CircularGaugeScaleLabelsSettingsBuilder> configurator)
    {
      this.Container.Labels.CircularGauge = this.Container.CircularGauge;
      configurator(new CircularGaugeScaleLabelsSettingsBuilder(this.Container.Labels));
      return this;
    }

    public CircularGaugeScaleSettingsBuilder MajorTicks(
      Action<CircularGaugeScaleMajorTicksSettingsBuilder> configurator)
    {
      this.Container.MajorTicks.CircularGauge = this.Container.CircularGauge;
      configurator(new CircularGaugeScaleMajorTicksSettingsBuilder(this.Container.MajorTicks));
      return this;
    }

    public CircularGaugeScaleSettingsBuilder MajorUnit(double value)
    {
      this.Container.MajorUnit = new double?(value);
      return this;
    }

    public CircularGaugeScaleSettingsBuilder Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public CircularGaugeScaleSettingsBuilder Min(double value)
    {
      this.Container.Min = new double?(value);
      return this;
    }

    public CircularGaugeScaleSettingsBuilder MinorTicks(
      Action<CircularGaugeScaleMinorTicksSettingsBuilder> configurator)
    {
      this.Container.MinorTicks.CircularGauge = this.Container.CircularGauge;
      configurator(new CircularGaugeScaleMinorTicksSettingsBuilder(this.Container.MinorTicks));
      return this;
    }

    public CircularGaugeScaleSettingsBuilder MinorUnit(double value)
    {
      this.Container.MinorUnit = new double?(value);
      return this;
    }

    public CircularGaugeScaleSettingsBuilder RangePlaceholderColor(
      string value)
    {
      this.Container.RangePlaceholderColor = value;
      return this;
    }

    public CircularGaugeScaleSettingsBuilder RangeSize(double value)
    {
      this.Container.RangeSize = new double?(value);
      return this;
    }

    public CircularGaugeScaleSettingsBuilder RangeDistance(
      double value)
    {
      this.Container.RangeDistance = new double?(value);
      return this;
    }

    public CircularGaugeScaleSettingsBuilder Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public CircularGaugeScaleSettingsBuilder Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public CircularGaugeScaleSettingsBuilder StartAngle(
      double value)
    {
      this.Container.StartAngle = new double?(value);
      return this;
    }
  }
}
