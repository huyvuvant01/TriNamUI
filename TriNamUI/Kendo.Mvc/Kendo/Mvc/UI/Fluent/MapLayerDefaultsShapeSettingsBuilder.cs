// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerDefaultsShapeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerDefaultsShapeSettingsBuilder
  {
    public MapLayerDefaultsShapeSettingsBuilder(MapLayerDefaultsShapeSettings container) => this.Container = container;

    protected MapLayerDefaultsShapeSettings Container { get; private set; }

    public MapLayerDefaultsShapeSettingsBuilder Attribution(
      string value)
    {
      this.Container.Attribution = value;
      return this;
    }

    public MapLayerDefaultsShapeSettingsBuilder Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public MapLayerDefaultsShapeSettingsBuilder Style(
      Action<MapLayerDefaultsShapeStyleSettingsBuilder> configurator)
    {
      this.Container.Style.Map = this.Container.Map;
      configurator(new MapLayerDefaultsShapeStyleSettingsBuilder(this.Container.Style));
      return this;
    }
  }
}
