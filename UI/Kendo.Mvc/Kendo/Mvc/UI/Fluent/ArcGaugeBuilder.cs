// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ArcGaugeBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ArcGaugeBuilder : WidgetBuilderBase<ArcGauge, ArcGaugeBuilder>
  {
    public ArcGaugeBuilder(ArcGauge component)
      : base(component)
    {
    }

    public ArcGaugeBuilder CenterTemplate(string value)
    {
      this.Container.CenterTemplate = value;
      return this;
    }

    public ArcGaugeBuilder CenterTemplateId(string templateId)
    {
      this.Container.CenterTemplateId = templateId;
      return this;
    }

    public ArcGaugeBuilder Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ArcGaugeBuilder Colors(Action<ArcGaugeColorFactory> configurator)
    {
      configurator(new ArcGaugeColorFactory(this.Container.Colors)
      {
        ArcGauge = this.Container
      });
      return this;
    }

    public ArcGaugeBuilder GaugeArea(
      Action<ArcGaugeGaugeAreaSettingsBuilder> configurator)
    {
      this.Container.GaugeArea.ArcGauge = this.Container;
      configurator(new ArcGaugeGaugeAreaSettingsBuilder(this.Container.GaugeArea));
      return this;
    }

    public ArcGaugeBuilder Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ArcGaugeBuilder Scale(Action<ArcGaugeScaleSettingsBuilder> configurator)
    {
      this.Container.Scale.ArcGauge = this.Container;
      configurator(new ArcGaugeScaleSettingsBuilder(this.Container.Scale));
      return this;
    }

    public ArcGaugeBuilder Theme(string value)
    {
      this.Container.Theme = value;
      return this;
    }

    public ArcGaugeBuilder Transitions(bool value)
    {
      this.Container.Transitions = new bool?(value);
      return this;
    }

    public ArcGaugeBuilder Value(double value)
    {
      this.Container.Value = new double?(value);
      return this;
    }

    public ArcGaugeBuilder RenderAs(RenderingMode value)
    {
      this.Container.RenderAs = new RenderingMode?(value);
      return this;
    }
  }
}
