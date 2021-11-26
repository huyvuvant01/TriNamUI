// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CircularGaugeGaugeAreaBorderSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class CircularGaugeGaugeAreaBorderSettingsBuilder
  {
    public CircularGaugeGaugeAreaBorderSettingsBuilder(
      CircularGaugeGaugeAreaBorderSettings container)
    {
      this.Container = container;
    }

    protected CircularGaugeGaugeAreaBorderSettings Container { get; private set; }

    public CircularGaugeGaugeAreaBorderSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public CircularGaugeGaugeAreaBorderSettingsBuilder DashType(
      string value)
    {
      this.Container.DashType = value;
      return this;
    }

    public CircularGaugeGaugeAreaBorderSettingsBuilder Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public CircularGaugeGaugeAreaBorderSettingsBuilder Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
