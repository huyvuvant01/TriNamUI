// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.LinearGaugeGaugeAreaBorderSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class LinearGaugeGaugeAreaBorderSettingsBuilder
  {
    public LinearGaugeGaugeAreaBorderSettingsBuilder(LinearGaugeGaugeAreaBorderSettings container) => this.Container = container;

    protected LinearGaugeGaugeAreaBorderSettings Container { get; private set; }

    public LinearGaugeGaugeAreaBorderSettingsBuilder Opacity(
      double opacity)
    {
      this.Container.Opacity = new double?(opacity);
      return this;
    }

    public LinearGaugeGaugeAreaBorderSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public LinearGaugeGaugeAreaBorderSettingsBuilder DashType(
      ChartDashType value)
    {
      this.Container.DashType = new ChartDashType?(value);
      return this;
    }

    public LinearGaugeGaugeAreaBorderSettingsBuilder Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
