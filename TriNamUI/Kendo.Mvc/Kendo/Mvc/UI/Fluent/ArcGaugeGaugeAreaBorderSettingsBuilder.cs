// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ArcGaugeGaugeAreaBorderSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ArcGaugeGaugeAreaBorderSettingsBuilder
  {
    public ArcGaugeGaugeAreaBorderSettingsBuilder(ArcGaugeGaugeAreaBorderSettings container) => this.Container = container;

    protected ArcGaugeGaugeAreaBorderSettings Container { get; private set; }

    public ArcGaugeGaugeAreaBorderSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ArcGaugeGaugeAreaBorderSettingsBuilder Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ArcGaugeGaugeAreaBorderSettingsBuilder Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public ArcGaugeGaugeAreaBorderSettingsBuilder DashType(
      Kendo.Mvc.UI.DashType value)
    {
      this.Container.DashType = new Kendo.Mvc.UI.DashType?(value);
      return this;
    }
  }
}
