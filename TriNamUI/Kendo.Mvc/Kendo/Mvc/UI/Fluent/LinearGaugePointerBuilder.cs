// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.LinearGaugePointerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class LinearGaugePointerBuilder
  {
    public LinearGaugePointerBuilder(LinearGaugePointer container) => this.Container = container;

    protected LinearGaugePointer Container { get; private set; }

    public LinearGaugePointerBuilder Border(
      Action<LinearGaugePointerBorderSettingsBuilder> configurator)
    {
      this.Container.Border.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugePointerBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public LinearGaugePointerBuilder Border(
      int width,
      string color,
      ChartDashType dashType)
    {
      this.Container.Border.LinearGauge = this.Container.LinearGauge;
      this.Container.Border.Width = new double?((double) width);
      this.Container.Border.Color = color;
      this.Container.Border.DashType = new ChartDashType?(dashType);
      return this;
    }

    public LinearGaugePointerBuilder Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public LinearGaugePointerBuilder Margin(double value)
    {
      this.Container.Margin.All(value);
      return this;
    }

    public LinearGaugePointerBuilder Margin(
      double top,
      double right,
      double bottom,
      double left)
    {
      this.Container.Margin.Top = new double?(top);
      this.Container.Margin.Right = new double?(right);
      this.Container.Margin.Bottom = new double?(bottom);
      this.Container.Margin.Left = new double?(left);
      return this;
    }

    public LinearGaugePointerBuilder Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public LinearGaugePointerBuilder Shape(GaugeLinearPointerShape value)
    {
      this.Container.Shape = new GaugeLinearPointerShape?(value);
      return this;
    }

    public LinearGaugePointerBuilder Size(double value)
    {
      this.Container.Size = new double?(value);
      return this;
    }

    public LinearGaugePointerBuilder Track(
      Action<LinearGaugePointerTrackSettingsBuilder> configurator)
    {
      this.Container.Track.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugePointerTrackSettingsBuilder(this.Container.Track));
      return this;
    }

    public LinearGaugePointerBuilder Value(double value)
    {
      this.Container.Value = new double?(value);
      return this;
    }
  }
}
