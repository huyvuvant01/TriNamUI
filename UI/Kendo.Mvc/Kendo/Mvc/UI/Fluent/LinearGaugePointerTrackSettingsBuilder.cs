// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.LinearGaugePointerTrackSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class LinearGaugePointerTrackSettingsBuilder
  {
    public LinearGaugePointerTrackSettingsBuilder(LinearGaugePointerTrackSettings container) => this.Container = container;

    protected LinearGaugePointerTrackSettings Container { get; private set; }

    public LinearGaugePointerTrackSettingsBuilder Border(
      Action<LinearGaugePointerTrackBorderSettingsBuilder> configurator)
    {
      this.Container.Border.LinearGauge = this.Container.LinearGauge;
      configurator(new LinearGaugePointerTrackBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public LinearGaugePointerTrackSettingsBuilder Border(
      int width,
      string color,
      ChartDashType dashType)
    {
      this.Container.Border.Width = new double?((double) width);
      this.Container.Border.Color = color;
      this.Container.Border.DashType = new ChartDashType?(dashType);
      return this;
    }

    public LinearGaugePointerTrackSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public LinearGaugePointerTrackSettingsBuilder Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public LinearGaugePointerTrackSettingsBuilder Size(
      double value)
    {
      this.Container.Size = new double?(value);
      return this;
    }

    public LinearGaugePointerTrackSettingsBuilder Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public LinearGaugePointerTrackSettingsBuilder Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
