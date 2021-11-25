// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapBuilder : WidgetBuilderBase<Map, MapBuilder>
  {
    public MapBuilder(Map component)
      : base(component)
    {
    }

    public MapBuilder Center(params double[] value)
    {
      this.Container.Center = value;
      return this;
    }

    public MapBuilder Controls(Action<MapControlsSettingsBuilder> configurator)
    {
      this.Container.Controls.Map = this.Container;
      configurator(new MapControlsSettingsBuilder(this.Container.Controls));
      return this;
    }

    public MapBuilder LayerDefaults(
      Action<MapLayerDefaultsSettingsBuilder> configurator)
    {
      this.Container.LayerDefaults.Map = this.Container;
      configurator(new MapLayerDefaultsSettingsBuilder(this.Container.LayerDefaults));
      return this;
    }

    public MapBuilder Layers(Action<MapLayerFactory> configurator)
    {
      configurator(new MapLayerFactory(this.Container.Layers)
      {
        Map = this.Container
      });
      return this;
    }

    public MapBuilder MarkerDefaults(
      Action<MapMarkerDefaultsSettingsBuilder> configurator)
    {
      this.Container.MarkerDefaults.Map = this.Container;
      configurator(new MapMarkerDefaultsSettingsBuilder(this.Container.MarkerDefaults));
      return this;
    }

    public MapBuilder Markers(Action<MapMarkerFactory> configurator)
    {
      configurator(new MapMarkerFactory(this.Container.Markers)
      {
        Map = this.Container
      });
      return this;
    }

    public MapBuilder MinZoom(double value)
    {
      this.Container.MinZoom = new double?(value);
      return this;
    }

    public MapBuilder MaxZoom(double value)
    {
      this.Container.MaxZoom = new double?(value);
      return this;
    }

    public MapBuilder MinSize(double value)
    {
      this.Container.MinSize = new double?(value);
      return this;
    }

    public MapBuilder Pannable(bool value)
    {
      this.Container.Pannable = new bool?(value);
      return this;
    }

    public MapBuilder Wraparound(bool value)
    {
      this.Container.Wraparound = new bool?(value);
      return this;
    }

    public MapBuilder Zoom(double value)
    {
      this.Container.Zoom = new double?(value);
      return this;
    }

    public MapBuilder Zoomable(bool value)
    {
      this.Container.Zoomable = new bool?(value);
      return this;
    }

    public MapBuilder Events(Action<MapEventBuilder> configurator)
    {
      configurator(new MapEventBuilder(this.Container.Events));
      return this;
    }
  }
}
