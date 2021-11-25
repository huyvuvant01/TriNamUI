// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CircularGaugeBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CircularGaugeBuilder : WidgetBuilderBase<CircularGauge, CircularGaugeBuilder>
  {
    public CircularGaugeBuilder(CircularGauge component)
      : base(component)
    {
    }

    public CircularGaugeBuilder CenterTemplate(string value)
    {
      this.Container.CenterTemplate = value;
      return this;
    }

    public CircularGaugeBuilder CenterTemplateId(string templateId)
    {
      this.Container.CenterTemplateId = templateId;
      return this;
    }

    public CircularGaugeBuilder Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public CircularGaugeBuilder Colors(
      Action<CircularGaugeColorFactory> configurator)
    {
      configurator(new CircularGaugeColorFactory(this.Container.Colors)
      {
        CircularGauge = this.Container
      });
      return this;
    }

    public CircularGaugeBuilder GaugeArea(
      Action<CircularGaugeGaugeAreaSettingsBuilder> configurator)
    {
      this.Container.GaugeArea.CircularGauge = this.Container;
      configurator(new CircularGaugeGaugeAreaSettingsBuilder(this.Container.GaugeArea));
      return this;
    }

    public CircularGaugeBuilder Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public CircularGaugeBuilder RenderAs(string value)
    {
      this.Container.RenderAs = value;
      return this;
    }

    public CircularGaugeBuilder Scale(
      Action<CircularGaugeScaleSettingsBuilder> configurator)
    {
      this.Container.Scale.CircularGauge = this.Container;
      configurator(new CircularGaugeScaleSettingsBuilder(this.Container.Scale));
      return this;
    }

    public CircularGaugeBuilder Theme(string value)
    {
      this.Container.Theme = value;
      return this;
    }

    public CircularGaugeBuilder Transitions(bool value)
    {
      this.Container.Transitions = new bool?(value);
      return this;
    }

    public CircularGaugeBuilder Value(double value)
    {
      this.Container.Value = new double?(value);
      return this;
    }
  }
}
