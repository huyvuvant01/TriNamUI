// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerDefaultsBubbleStyleFillSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerDefaultsBubbleStyleFillSettingsBuilder
  {
    public MapLayerDefaultsBubbleStyleFillSettingsBuilder(
      MapLayerDefaultsBubbleStyleFillSettings container)
    {
      this.Container = container;
    }

    protected MapLayerDefaultsBubbleStyleFillSettings Container { get; private set; }

    public MapLayerDefaultsBubbleStyleFillSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public MapLayerDefaultsBubbleStyleFillSettingsBuilder Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }
  }
}
