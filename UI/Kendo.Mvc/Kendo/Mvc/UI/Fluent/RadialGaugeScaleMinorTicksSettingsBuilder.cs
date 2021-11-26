// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadialGaugeScaleMinorTicksSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class RadialGaugeScaleMinorTicksSettingsBuilder
  {
    public RadialGaugeScaleMinorTicksSettingsBuilder(RadialGaugeScaleMinorTicksSettings container) => this.Container = container;

    protected RadialGaugeScaleMinorTicksSettings Container { get; private set; }

    public RadialGaugeScaleMinorTicksSettingsBuilder DashType(
      ChartDashType dashType)
    {
      this.Container.DashType = new ChartDashType?(dashType);
      return this;
    }

    public RadialGaugeScaleMinorTicksSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public RadialGaugeScaleMinorTicksSettingsBuilder Size(
      double value)
    {
      this.Container.Size = new double?(value);
      return this;
    }

    public RadialGaugeScaleMinorTicksSettingsBuilder Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public RadialGaugeScaleMinorTicksSettingsBuilder Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
