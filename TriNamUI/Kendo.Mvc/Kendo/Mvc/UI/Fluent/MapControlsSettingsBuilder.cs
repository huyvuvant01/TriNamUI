// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapControlsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapControlsSettingsBuilder
  {
    public MapControlsSettingsBuilder(MapControlsSettings container) => this.Container = container;

    protected MapControlsSettings Container { get; private set; }

    public MapControlsSettingsBuilder Attribution(
      Action<MapControlsAttributionSettingsBuilder> configurator)
    {
      this.Container.Attribution.Enabled = new bool?(true);
      this.Container.Attribution.Map = this.Container.Map;
      configurator(new MapControlsAttributionSettingsBuilder(this.Container.Attribution));
      return this;
    }

    public MapControlsSettingsBuilder Attribution(bool enabled)
    {
      this.Container.Attribution.Enabled = new bool?(enabled);
      return this;
    }

    public MapControlsSettingsBuilder Navigator(
      Action<MapControlsNavigatorSettingsBuilder> configurator)
    {
      this.Container.Navigator.Enabled = new bool?(true);
      this.Container.Navigator.Map = this.Container.Map;
      configurator(new MapControlsNavigatorSettingsBuilder(this.Container.Navigator));
      return this;
    }

    public MapControlsSettingsBuilder Navigator(bool enabled)
    {
      this.Container.Navigator.Enabled = new bool?(enabled);
      return this;
    }

    public MapControlsSettingsBuilder Zoom(
      Action<MapControlsZoomSettingsBuilder> configurator)
    {
      this.Container.Zoom.Enabled = new bool?(true);
      this.Container.Zoom.Map = this.Container.Map;
      configurator(new MapControlsZoomSettingsBuilder(this.Container.Zoom));
      return this;
    }

    public MapControlsSettingsBuilder Zoom(bool enabled)
    {
      this.Container.Zoom.Enabled = new bool?(enabled);
      return this;
    }
  }
}
