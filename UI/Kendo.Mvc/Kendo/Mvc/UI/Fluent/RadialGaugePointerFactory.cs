// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadialGaugePointerFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class RadialGaugePointerFactory
  {
    public RadialGauge RadialGauge { get; set; }

    public RadialGaugePointerFactory(List<RadialGaugePointer> container) => this.Container = container;

    protected List<RadialGaugePointer> Container { get; private set; }

    public virtual RadialGaugePointerBuilder Add()
    {
      RadialGaugePointer container = new RadialGaugePointer();
      container.RadialGauge = this.RadialGauge;
      this.Container.Add(container);
      return new RadialGaugePointerBuilder(container);
    }
  }
}
