// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CircularGaugeColorBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class CircularGaugeColorBuilder
  {
    public CircularGaugeColorBuilder(CircularGaugeColor container) => this.Container = container;

    protected CircularGaugeColor Container { get; private set; }

    public CircularGaugeColorBuilder Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public CircularGaugeColorBuilder From(double value)
    {
      this.Container.From = new double?(value);
      return this;
    }

    public CircularGaugeColorBuilder To(double value)
    {
      this.Container.To = new double?(value);
      return this;
    }
  }
}
