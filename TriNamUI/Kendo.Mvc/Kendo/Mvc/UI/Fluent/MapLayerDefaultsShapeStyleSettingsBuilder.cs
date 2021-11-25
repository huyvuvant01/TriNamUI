// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerDefaultsShapeStyleSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerDefaultsShapeStyleSettingsBuilder
  {
    public MapLayerDefaultsShapeStyleSettingsBuilder(MapLayerDefaultsShapeStyleSettings container) => this.Container = container;

    protected MapLayerDefaultsShapeStyleSettings Container { get; private set; }

    public MapLayerDefaultsShapeStyleSettingsBuilder Fill(
      Action<MapLayerDefaultsShapeStyleFillSettingsBuilder> configurator)
    {
      this.Container.Fill.Map = this.Container.Map;
      configurator(new MapLayerDefaultsShapeStyleFillSettingsBuilder(this.Container.Fill));
      return this;
    }

    public MapLayerDefaultsShapeStyleSettingsBuilder Stroke(
      Action<MapLayerDefaultsShapeStyleStrokeSettingsBuilder> configurator)
    {
      this.Container.Stroke.Map = this.Container.Map;
      configurator(new MapLayerDefaultsShapeStyleStrokeSettingsBuilder(this.Container.Stroke));
      return this;
    }
  }
}
