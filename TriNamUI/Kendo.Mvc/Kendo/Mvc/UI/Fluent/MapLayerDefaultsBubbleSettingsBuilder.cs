// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerDefaultsBubbleSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerDefaultsBubbleSettingsBuilder
  {
    public MapLayerDefaultsBubbleSettingsBuilder(MapLayerDefaultsBubbleSettings container) => this.Container = container;

    protected MapLayerDefaultsBubbleSettings Container { get; private set; }

    public MapLayerDefaultsBubbleSettingsBuilder Symbol(
      string symbol)
    {
      this.Container.SymbolName = symbol;
      return this;
    }

    public MapLayerDefaultsBubbleSettingsBuilder SymbolHandler(
      string handler)
    {
      this.Container.SymbolHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public MapLayerDefaultsBubbleSettingsBuilder Attribution(
      string value)
    {
      this.Container.Attribution = value;
      return this;
    }

    public MapLayerDefaultsBubbleSettingsBuilder Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public MapLayerDefaultsBubbleSettingsBuilder MaxSize(
      double value)
    {
      this.Container.MaxSize = new double?(value);
      return this;
    }

    public MapLayerDefaultsBubbleSettingsBuilder MinSize(
      double value)
    {
      this.Container.MinSize = new double?(value);
      return this;
    }

    public MapLayerDefaultsBubbleSettingsBuilder Style(
      Action<MapLayerDefaultsBubbleStyleSettingsBuilder> configurator)
    {
      this.Container.Style.Map = this.Container.Map;
      configurator(new MapLayerDefaultsBubbleStyleSettingsBuilder(this.Container.Style));
      return this;
    }

    public MapLayerDefaultsBubbleSettingsBuilder Symbol(
      MapSymbol value)
    {
      this.Container.Symbol = new MapSymbol?(value);
      return this;
    }
  }
}
