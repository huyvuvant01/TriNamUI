// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.LinearGaugeScaleSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class LinearGaugeScaleSettingsBuilder
  {
    public LinearGaugeScaleSettingsBuilder(LinearGaugeScaleSettings container) => this.Container = container;

    protected LinearGaugeScaleSettings Container { get; private set; }

    public LinearGaugeScaleSettingsBuilder Line(
      Action<LinearGaugeScaleLineSettingsBuilder> configurator)
    {
      this.Container.Line.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugeScaleLineSettingsBuilder(this.Container.Line));
      return this;
    }

    public LinearGaugeScaleSettingsBuilder Labels(
      Action<LinearGaugeScaleLabelsSettingsBuilder> configurator)
    {
      this.Container.Labels.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugeScaleLabelsSettingsBuilder(this.Container.Labels));
      return this;
    }

    public LinearGaugeScaleSettingsBuilder MajorTicks(
      Action<LinearGaugeScaleMajorTicksSettingsBuilder> configurator)
    {
      this.Container.MajorTicks.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugeScaleMajorTicksSettingsBuilder(this.Container.MajorTicks));
      return this;
    }

    public LinearGaugeScaleSettingsBuilder MajorUnit(double value)
    {
      this.Container.MajorUnit = new double?(value);
      return this;
    }

    public LinearGaugeScaleSettingsBuilder Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public LinearGaugeScaleSettingsBuilder Min(double value)
    {
      this.Container.Min = new double?(value);
      return this;
    }

    public LinearGaugeScaleSettingsBuilder MinorTicks(
      Action<LinearGaugeScaleMinorTicksSettingsBuilder> configurator)
    {
      this.Container.MinorTicks.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugeScaleMinorTicksSettingsBuilder(this.Container.MinorTicks));
      return this;
    }

    public LinearGaugeScaleSettingsBuilder MinorUnit(double value)
    {
      this.Container.MinorUnit = new double?(value);
      return this;
    }

    public LinearGaugeScaleSettingsBuilder Mirror(bool value)
    {
      this.Container.Mirror = new bool?(value);
      return this;
    }

    public LinearGaugeScaleSettingsBuilder Ranges(
      Action<LinearGaugeScaleSettingsRangeFactory> configurator)
    {
      configurator(new LinearGaugeScaleSettingsRangeFactory(this.Container.Ranges)
      {
        LinearGauge = this.Container.LinearGauge
      });
      return this;
    }

    public LinearGaugeScaleSettingsBuilder RangePlaceholderColor(
      string value)
    {
      this.Container.RangePlaceholderColor = value;
      return this;
    }

    public LinearGaugeScaleSettingsBuilder RangeSize(double value)
    {
      this.Container.RangeSize = new double?(value);
      return this;
    }

    public LinearGaugeScaleSettingsBuilder Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public LinearGaugeScaleSettingsBuilder Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public LinearGaugeScaleSettingsBuilder Vertical(bool value)
    {
      this.Container.Vertical = new bool?(value);
      return this;
    }
  }
}
