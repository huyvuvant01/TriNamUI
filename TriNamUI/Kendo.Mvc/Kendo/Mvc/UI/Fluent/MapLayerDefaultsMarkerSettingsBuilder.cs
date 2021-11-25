// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerDefaultsMarkerSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerDefaultsMarkerSettingsBuilder
  {
    public MapLayerDefaultsMarkerSettingsBuilder(MapLayerDefaultsMarkerSettings container) => this.Container = container;

    protected MapLayerDefaultsMarkerSettings Container { get; private set; }

    public MapLayerDefaultsMarkerSettingsBuilder Shape(
      string name)
    {
      this.Container.ShapeName = name;
      return this;
    }

    public MapLayerDefaultsMarkerSettingsBuilder Tooltip(
      Action<MapMarkerTooltipBuilder> configurator)
    {
      configurator(new MapMarkerTooltipBuilder(this.Container.Tooltip));
      return this;
    }

    public MapLayerDefaultsMarkerSettingsBuilder Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public MapLayerDefaultsMarkerSettingsBuilder Shape(
      MapMarkersShape value)
    {
      this.Container.Shape = new MapMarkersShape?(value);
      return this;
    }
  }
}
