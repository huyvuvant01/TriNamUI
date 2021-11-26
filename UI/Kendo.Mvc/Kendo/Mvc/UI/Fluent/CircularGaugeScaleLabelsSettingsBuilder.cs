// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CircularGaugeScaleLabelsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CircularGaugeScaleLabelsSettingsBuilder
  {
    public CircularGaugeScaleLabelsSettingsBuilder(CircularGaugeScaleLabelsSettings container) => this.Container = container;

    protected CircularGaugeScaleLabelsSettings Container { get; private set; }

    public CircularGaugeScaleLabelsSettingsBuilder Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder Border(
      Action<CircularGaugeScaleLabelsBorderSettingsBuilder> configurator)
    {
      this.Container.Border.CircularGauge = this.Container.CircularGauge;
      configurator(new CircularGaugeScaleLabelsBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder Margin(
      Action<CircularGaugeScaleLabelsMarginSettingsBuilder> configurator)
    {
      this.Container.Margin.CircularGauge = this.Container.CircularGauge;
      configurator(new CircularGaugeScaleLabelsMarginSettingsBuilder(this.Container.Margin));
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder Padding(
      Action<CircularGaugeScaleLabelsPaddingSettingsBuilder> configurator)
    {
      this.Container.Padding.CircularGauge = this.Container.CircularGauge;
      configurator(new CircularGaugeScaleLabelsPaddingSettingsBuilder(this.Container.Padding));
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public CircularGaugeScaleLabelsSettingsBuilder Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
