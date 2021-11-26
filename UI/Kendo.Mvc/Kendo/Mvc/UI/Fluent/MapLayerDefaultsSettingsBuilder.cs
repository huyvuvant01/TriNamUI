// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerDefaultsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerDefaultsSettingsBuilder
  {
    public MapLayerDefaultsSettingsBuilder(MapLayerDefaultsSettings container) => this.Container = container;

    protected MapLayerDefaultsSettings Container { get; private set; }

    public MapLayerDefaultsSettingsBuilder Marker(
      Action<MapLayerDefaultsMarkerSettingsBuilder> configurator)
    {
      this.Container.Marker.Map = this.Container.Map;
      configurator(new MapLayerDefaultsMarkerSettingsBuilder(this.Container.Marker));
      return this;
    }

    public MapLayerDefaultsSettingsBuilder Shape(
      Action<MapLayerDefaultsShapeSettingsBuilder> configurator)
    {
      this.Container.Shape.Map = this.Container.Map;
      configurator(new MapLayerDefaultsShapeSettingsBuilder(this.Container.Shape));
      return this;
    }

    public MapLayerDefaultsSettingsBuilder Bubble(
      Action<MapLayerDefaultsBubbleSettingsBuilder> configurator)
    {
      this.Container.Bubble.Map = this.Container.Map;
      configurator(new MapLayerDefaultsBubbleSettingsBuilder(this.Container.Bubble));
      return this;
    }

    public MapLayerDefaultsSettingsBuilder TileSize(double value)
    {
      this.Container.TileSize = new double?(value);
      return this;
    }

    public MapLayerDefaultsSettingsBuilder Tile(
      Action<MapLayerDefaultsTileSettingsBuilder> configurator)
    {
      this.Container.Tile.Map = this.Container.Map;
      configurator(new MapLayerDefaultsTileSettingsBuilder(this.Container.Tile));
      return this;
    }

    public MapLayerDefaultsSettingsBuilder Bing(
      Action<MapLayerDefaultsBingSettingsBuilder> configurator)
    {
      this.Container.Bing.Map = this.Container.Map;
      configurator(new MapLayerDefaultsBingSettingsBuilder(this.Container.Bing));
      return this;
    }
  }
}
