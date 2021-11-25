// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ArcGaugeScaleLabelsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ArcGaugeScaleLabelsSettingsBuilder
  {
    public ArcGaugeScaleLabelsSettingsBuilder(ArcGaugeScaleLabelsSettings container) => this.Container = container;

    protected ArcGaugeScaleLabelsSettings Container { get; private set; }

    public ArcGaugeScaleLabelsSettingsBuilder Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder Border(
      Action<ArcGaugeScaleLabelsBorderSettingsBuilder> configurator)
    {
      this.Container.Border.ArcGauge = this.Container.ArcGauge;
      configurator(new ArcGaugeScaleLabelsBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder Font(string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder Margin(
      Action<ArcGaugeScaleLabelsMarginSettingsBuilder> configurator)
    {
      this.Container.Margin.ArcGauge = this.Container.ArcGauge;
      configurator(new ArcGaugeScaleLabelsMarginSettingsBuilder(this.Container.Margin));
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder Padding(
      Action<ArcGaugeScaleLabelsPaddingSettingsBuilder> configurator)
    {
      this.Container.Padding.ArcGauge = this.Container.ArcGauge;
      configurator(new ArcGaugeScaleLabelsPaddingSettingsBuilder(this.Container.Padding));
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }

    public ArcGaugeScaleLabelsSettingsBuilder Position(
      ArcGaugeScaleLabelsPosition value)
    {
      this.Container.Position = new ArcGaugeScaleLabelsPosition?(value);
      return this;
    }
  }
}
