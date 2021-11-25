// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.LinearGaugeBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class LinearGaugeBuilder : WidgetBuilderBase<LinearGauge, LinearGaugeBuilder>
  {
    public LinearGaugeBuilder(LinearGauge component)
      : base(component)
    {
    }

    public LinearGaugeBuilder Pointers(
      Action<LinearGaugePointerFactory> configurator)
    {
      configurator(new LinearGaugePointerFactory(this.Container.Pointers)
      {
        LinearGauge = this.Container
      });
      return this;
    }

    public LinearGaugeBuilder Pointer(
      Action<LinearGaugePointerBuilder> configurator)
    {
      configurator(new LinearGaugePointerBuilder(this.Container.Pointer));
      return this;
    }

    public LinearGaugeBuilder GaugeArea(
      Action<LinearGaugeGaugeAreaSettingsBuilder> configurator)
    {
      this.Container.GaugeArea.LinearGauge = this.Container;
      configurator(new LinearGaugeGaugeAreaSettingsBuilder(this.Container.GaugeArea));
      return this;
    }

    public LinearGaugeBuilder RenderAs(RenderingMode value)
    {
      this.Container.RenderAs = new RenderingMode?(value);
      return this;
    }

    public LinearGaugeBuilder Scale(
      Action<LinearGaugeScaleSettingsBuilder> configurator)
    {
      this.Container.Scale.LinearGauge = this.Container;
      configurator(new LinearGaugeScaleSettingsBuilder(this.Container.Scale));
      return this;
    }

    public LinearGaugeBuilder Theme(string value)
    {
      this.Container.Theme = value;
      return this;
    }

    public LinearGaugeBuilder Transitions(bool value)
    {
      this.Container.Transitions = new bool?(value);
      return this;
    }
  }
}
