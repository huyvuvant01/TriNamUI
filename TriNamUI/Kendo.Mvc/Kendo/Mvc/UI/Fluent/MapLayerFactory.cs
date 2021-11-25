// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerFactory
  {
    public MapLayerFactory(List<MapLayer> container) => this.Container = container;

    protected List<MapLayer> Container { get; private set; }

    public Map Map { get; set; }

    public virtual MapLayerBuilder Add()
    {
      MapLayer container = new MapLayer();
      container.Map = this.Map;
      this.Container.Add(container);
      return new MapLayerBuilder(container);
    }
  }
}
