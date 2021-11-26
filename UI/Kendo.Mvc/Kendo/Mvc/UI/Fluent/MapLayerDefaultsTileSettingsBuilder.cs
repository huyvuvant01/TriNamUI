// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerDefaultsTileSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerDefaultsTileSettingsBuilder
  {
    public MapLayerDefaultsTileSettingsBuilder(MapLayerDefaultsTileSettings container) => this.Container = container;

    protected MapLayerDefaultsTileSettings Container { get; private set; }

    public MapLayerDefaultsTileSettingsBuilder UrlTemplate(
      string value)
    {
      this.Container.UrlTemplate = value;
      return this;
    }

    public MapLayerDefaultsTileSettingsBuilder UrlTemplateId(
      string templateId)
    {
      this.Container.UrlTemplateId = templateId;
      return this;
    }

    public MapLayerDefaultsTileSettingsBuilder Attribution(
      string value)
    {
      this.Container.Attribution = value;
      return this;
    }

    public MapLayerDefaultsTileSettingsBuilder Subdomains(
      params string[] value)
    {
      this.Container.Subdomains = value;
      return this;
    }

    public MapLayerDefaultsTileSettingsBuilder Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }
  }
}
