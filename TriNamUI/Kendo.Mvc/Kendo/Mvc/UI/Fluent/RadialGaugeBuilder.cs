// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadialGaugeBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class RadialGaugeBuilder : 
    WidgetBuilderBase<RadialGauge, RadialGaugeBuilder>,
    IHideObjectMembers
  {
    public RadialGaugeBuilder(RadialGauge component)
      : base(component)
    {
    }

    public RadialGaugeBuilder RenderAs(RenderingMode renderAs)
    {
      this.Component.RenderAs = new RenderingMode?(renderAs);
      return this;
    }

    public RadialGaugeBuilder Pointers(
      Action<RadialGaugePointerFactory> configurator)
    {
      RadialGaugePointerFactory gaugePointerFactory = new RadialGaugePointerFactory(this.Container.Pointers);
      configurator(gaugePointerFactory);
      return this;
    }

    public RadialGaugeBuilder Pointer(
      Action<RadialGaugePointerBuilder> configurator)
    {
      configurator(new RadialGaugePointerBuilder(this.Container.Pointer));
      return this;
    }

    public RadialGaugeBuilder GaugeArea(
      Action<RadialGaugeGaugeAreaSettingsBuilder> configurator)
    {
      this.Container.GaugeArea.RadialGauge = this.Container;
      configurator(new RadialGaugeGaugeAreaSettingsBuilder(this.Container.GaugeArea));
      return this;
    }

    public RadialGaugeBuilder Scale(
      Action<RadialGaugeScaleSettingsBuilder> configurator)
    {
      this.Container.Scale.RadialGauge = this.Container;
      configurator(new RadialGaugeScaleSettingsBuilder(this.Container.Scale));
      return this;
    }

    public RadialGaugeBuilder Theme(string value)
    {
      this.Container.Theme = value;
      return this;
    }

    public RadialGaugeBuilder Transitions(bool value)
    {
      this.Container.Transitions = new bool?(value);
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
