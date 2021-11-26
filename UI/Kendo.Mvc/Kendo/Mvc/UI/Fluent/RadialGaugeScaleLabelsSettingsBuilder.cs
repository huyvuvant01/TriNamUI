// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadialGaugeScaleLabelsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class RadialGaugeScaleLabelsSettingsBuilder
  {
    public RadialGaugeScaleLabelsSettingsBuilder(RadialGaugeScaleLabelsSettings container) => this.Container = container;

    protected RadialGaugeScaleLabelsSettings Container { get; private set; }

    public RadialGaugeScaleLabelsSettingsBuilder Margin(
      int top,
      int right,
      int bottom,
      int left)
    {
      this.Container.Margin.Top = new double?((double) top);
      this.Container.Margin.Right = new double?((double) right);
      this.Container.Margin.Bottom = new double?((double) bottom);
      this.Container.Margin.Left = new double?((double) left);
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Margin(
      int margin)
    {
      this.Container.Margin.All((double) margin);
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Padding(
      int top,
      int right,
      int bottom,
      int left)
    {
      this.Container.Padding.Top = new double?((double) top);
      this.Container.Padding.Right = new double?((double) right);
      this.Container.Padding.Bottom = new double?((double) bottom);
      this.Container.Padding.Left = new double?((double) left);
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Padding(
      int padding)
    {
      this.Container.Padding.All((double) padding);
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Border(
      int width,
      string color,
      ChartDashType dashType)
    {
      this.Container.Border.Width = new double?((double) width);
      this.Container.Border.Color = color;
      this.Container.Border.DashType = new ChartDashType?(dashType);
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Opacity(
      double opacity)
    {
      this.Container.Opacity = new double?(opacity);
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Border(
      Action<RadialGaugeScaleLabelsBorderSettingsBuilder> configurator)
    {
      this.Container.Border.RadialGauge = this.Container.RadialGauge;
      configurator(new RadialGaugeScaleLabelsBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Margin(
      Action<RadialGaugeScaleLabelsMarginSettingsBuilder> configurator)
    {
      this.Container.Margin.RadialGauge = this.Container.RadialGauge;
      configurator(new RadialGaugeScaleLabelsMarginSettingsBuilder(this.Container.Margin));
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Padding(
      Action<RadialGaugeScaleLabelsPaddingSettingsBuilder> configurator)
    {
      this.Container.Padding.RadialGauge = this.Container.RadialGauge;
      configurator(new RadialGaugeScaleLabelsPaddingSettingsBuilder(this.Container.Padding));
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public RadialGaugeScaleLabelsSettingsBuilder Position(
      GaugeRadialScaleLabelsPosition value)
    {
      this.Container.Position = new GaugeRadialScaleLabelsPosition?(value);
      return this;
    }
  }
}
