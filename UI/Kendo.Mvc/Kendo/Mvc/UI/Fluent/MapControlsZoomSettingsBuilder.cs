// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapControlsZoomSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MapControlsZoomSettingsBuilder
  {
    public MapControlsZoomSettingsBuilder(MapControlsZoomSettings container) => this.Container = container;

    protected MapControlsZoomSettings Container { get; private set; }

    public MapControlsZoomSettingsBuilder Position(
      MapControlPosition value)
    {
      this.Container.Position = new MapControlPosition?(value);
      return this;
    }
  }
}
