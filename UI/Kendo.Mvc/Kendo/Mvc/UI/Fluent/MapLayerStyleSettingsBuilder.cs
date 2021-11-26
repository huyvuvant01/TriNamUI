// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerStyleSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerStyleSettingsBuilder
  {
    public MapLayerStyleSettingsBuilder(MapLayerStyleSettings container) => this.Container = container;

    protected MapLayerStyleSettings Container { get; private set; }

    public MapLayerStyleSettingsBuilder Fill(
      Action<MapLayerStyleFillSettingsBuilder> configurator)
    {
      this.Container.Fill.Map = this.Container.Map;
      configurator(new MapLayerStyleFillSettingsBuilder(this.Container.Fill));
      return this;
    }

    public MapLayerStyleSettingsBuilder Stroke(
      Action<MapLayerStyleStrokeSettingsBuilder> configurator)
    {
      this.Container.Stroke.Map = this.Container.Map;
      configurator(new MapLayerStyleStrokeSettingsBuilder(this.Container.Stroke));
      return this;
    }
  }
}
