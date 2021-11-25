// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadialGaugeGaugeAreaSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class RadialGaugeGaugeAreaSettingsBuilder : IHideObjectMembers
  {
    public RadialGaugeGaugeAreaSettingsBuilder(RadialGaugeGaugeAreaSettings container) => this.Container = container;

    protected RadialGaugeGaugeAreaSettings Container { get; private set; }

    public RadialGaugeGaugeAreaSettingsBuilder Margin(
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

    public RadialGaugeGaugeAreaSettingsBuilder Margin(int margin)
    {
      this.Container.Margin.All((double) margin);
      return this;
    }

    public RadialGaugeGaugeAreaSettingsBuilder Border(
      int width,
      string color,
      ChartDashType dashType)
    {
      this.Container.Border.Width = new double?((double) width);
      this.Container.Border.Color = color;
      this.Container.Border.DashType = new ChartDashType?(dashType);
      return this;
    }

    public RadialGaugeGaugeAreaSettingsBuilder Border(
      Action<RadialGaugeGaugeAreaBorderSettingsBuilder> configurator)
    {
      this.Container.Border.RadialGauge = this.Container.RadialGauge;
      configurator(new RadialGaugeGaugeAreaBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public RadialGaugeGaugeAreaSettingsBuilder Height(
      double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public RadialGaugeGaugeAreaSettingsBuilder Margin(
      Action<RadialGaugeGaugeAreaMarginSettingsBuilder> configurator)
    {
      this.Container.Margin.RadialGauge = this.Container.RadialGauge;
      configurator(new RadialGaugeGaugeAreaMarginSettingsBuilder(this.Container.Margin));
      return this;
    }

    public RadialGaugeGaugeAreaSettingsBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public RadialGaugeGaugeAreaSettingsBuilder Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
