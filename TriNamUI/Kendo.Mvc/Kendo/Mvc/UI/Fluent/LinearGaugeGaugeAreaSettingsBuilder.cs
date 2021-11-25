// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.LinearGaugeGaugeAreaSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class LinearGaugeGaugeAreaSettingsBuilder
  {
    public LinearGaugeGaugeAreaSettingsBuilder(LinearGaugeGaugeAreaSettings container) => this.Container = container;

    public LinearGaugeGaugeAreaSettingsBuilder Margin(int margin)
    {
      this.Container.Margin.All((double) margin);
      return this;
    }

    public LinearGaugeGaugeAreaSettingsBuilder Margin(
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

    protected LinearGaugeGaugeAreaSettings Container { get; private set; }

    public LinearGaugeGaugeAreaSettingsBuilder Border(
      int width,
      string color,
      ChartDashType dashType)
    {
      this.Container.Border.Width = new double?((double) width);
      this.Container.Border.Color = color;
      this.Container.Border.DashType = new ChartDashType?(dashType);
      return this;
    }

    public LinearGaugeGaugeAreaSettingsBuilder Border(
      Action<LinearGaugeGaugeAreaBorderSettingsBuilder> configurator)
    {
      this.Container.Border.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugeGaugeAreaBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public LinearGaugeGaugeAreaSettingsBuilder Height(
      double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public LinearGaugeGaugeAreaSettingsBuilder Margin(
      Action<LinearGaugeGaugeAreaMarginSettingsBuilder> configurator)
    {
      this.Container.Margin.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugeGaugeAreaMarginSettingsBuilder(this.Container.Margin));
      return this;
    }

    public LinearGaugeGaugeAreaSettingsBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public LinearGaugeGaugeAreaSettingsBuilder Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }
  }
}
