// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.LinearGaugeScaleLabelsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class LinearGaugeScaleLabelsSettingsBuilder
  {
    public LinearGaugeScaleLabelsSettingsBuilder(LinearGaugeScaleLabelsSettings container) => this.Container = container;

    protected LinearGaugeScaleLabelsSettings Container { get; private set; }

    public LinearGaugeScaleLabelsSettingsBuilder Margin(
      int margin)
    {
      this.Container.Margin.All((double) margin);
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Margin(
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

    public LinearGaugeScaleLabelsSettingsBuilder Padding(
      int padding)
    {
      this.Container.Padding.All((double) padding);
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Padding(
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

    public LinearGaugeScaleLabelsSettingsBuilder Border(
      int width,
      string color,
      ChartDashType dashType)
    {
      this.Container.Border.Width = new double?((double) width);
      this.Container.Border.Color = color;
      this.Container.Border.DashType = new ChartDashType?(dashType);
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Opacity(
      double opacity)
    {
      this.Container.Opacity = new double?(opacity);
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Border(
      Action<LinearGaugeScaleLabelsBorderSettingsBuilder> configurator)
    {
      this.Container.Border.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugeScaleLabelsBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Margin(
      Action<LinearGaugeScaleLabelsMarginSettingsBuilder> configurator)
    {
      this.Container.Margin.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugeScaleLabelsMarginSettingsBuilder(this.Container.Margin));
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Padding(
      Action<LinearGaugeScaleLabelsPaddingSettingsBuilder> configurator)
    {
      this.Container.Padding.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugeScaleLabelsPaddingSettingsBuilder(this.Container.Padding));
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public LinearGaugeScaleLabelsSettingsBuilder Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
