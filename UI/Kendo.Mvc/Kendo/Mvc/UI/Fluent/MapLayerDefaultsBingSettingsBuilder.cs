// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerDefaultsBingSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerDefaultsBingSettingsBuilder
  {
    public MapLayerDefaultsBingSettingsBuilder(MapLayerDefaultsBingSettings container) => this.Container = container;

    protected MapLayerDefaultsBingSettings Container { get; private set; }

    public MapLayerDefaultsBingSettingsBuilder Attribution(
      string value)
    {
      this.Container.Attribution = value;
      return this;
    }

    public MapLayerDefaultsBingSettingsBuilder Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public MapLayerDefaultsBingSettingsBuilder Key(string value)
    {
      this.Container.Key = value;
      return this;
    }

    public MapLayerDefaultsBingSettingsBuilder Culture(
      string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public MapLayerDefaultsBingSettingsBuilder ImagerySet(
      MapLayersImagerySet value)
    {
      this.Container.ImagerySet = new MapLayersImagerySet?(value);
      return this;
    }
  }
}
