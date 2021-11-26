// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadialGaugePointerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class RadialGaugePointerBuilder
  {
    public RadialGaugePointerBuilder(RadialGaugePointer container) => this.Container = container;

    protected RadialGaugePointer Container { get; private set; }

    public RadialGaugePointerBuilder Cap(
      Action<RadialGaugePointerCapSettingsBuilder> configurator)
    {
      this.Container.Cap.RadialGauge = this.Container.RadialGauge;
      configurator(new RadialGaugePointerCapSettingsBuilder(this.Container.Cap));
      return this;
    }

    public RadialGaugePointerBuilder Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public RadialGaugePointerBuilder Length(double length)
    {
      this.Container.Length = new double?(length);
      return this;
    }

    public RadialGaugePointerBuilder Value(double value)
    {
      this.Container.Value = new double?(value);
      return this;
    }

    public RadialGaugePointerBuilder Opacity(double opacity)
    {
      this.Container.Opacity = new double?(opacity);
      return this;
    }
  }
}
