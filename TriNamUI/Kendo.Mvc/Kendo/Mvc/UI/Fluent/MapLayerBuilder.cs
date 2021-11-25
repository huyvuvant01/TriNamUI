// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerBuilder
  {
    public MapLayerBuilder(MapLayer container) => this.Container = container;

    protected MapLayer Container { get; private set; }

    public MapLayerBuilder DataSource(Action<MapLayerDataSourceBuilder> configurator)
    {
      this.Container.DataSource = new Kendo.Mvc.UI.DataSource(this.Container.Map.ModelMetadataProvider);
      configurator(new MapLayerDataSourceBuilder(this.Container.DataSource, this.Container.Map.ViewContext, this.Container.Map.UrlGenerator));
      return this;
    }

    public MapLayerBuilder Shape(string name)
    {
      this.Container.ShapeName = name;
      return this;
    }

    public MapLayerBuilder Symbol(string symbol)
    {
      this.Container.SymbolName = symbol;
      return this;
    }

    public MapLayerBuilder SymbolHandler(string handler)
    {
      this.Container.SymbolHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public MapLayerBuilder Tooltip(Action<MapMarkerTooltipBuilder> configurator)
    {
      configurator(new MapMarkerTooltipBuilder(this.Container.Tooltip));
      return this;
    }

    public MapLayerBuilder Attribution(string value)
    {
      this.Container.Attribution = value;
      return this;
    }

    public MapLayerBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public MapLayerBuilder Extent(params double[] value)
    {
      this.Container.Extent = value;
      return this;
    }

    public MapLayerBuilder Key(string value)
    {
      this.Container.Key = value;
      return this;
    }

    public MapLayerBuilder Culture(string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public MapLayerBuilder LocationField(string value)
    {
      this.Container.LocationField = value;
      return this;
    }

    public MapLayerBuilder TileSize(double value)
    {
      this.Container.TileSize = new double?(value);
      return this;
    }

    public MapLayerBuilder TitleField(string value)
    {
      this.Container.TitleField = value;
      return this;
    }

    public MapLayerBuilder MaxSize(double value)
    {
      this.Container.MaxSize = new double?(value);
      return this;
    }

    public MapLayerBuilder MinSize(double value)
    {
      this.Container.MinSize = new double?(value);
      return this;
    }

    public MapLayerBuilder MaxZoom(double value)
    {
      this.Container.MaxZoom = new double?(value);
      return this;
    }

    public MapLayerBuilder MinZoom(double value)
    {
      this.Container.MinZoom = new double?(value);
      return this;
    }

    public MapLayerBuilder Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public MapLayerBuilder Subdomains(params string[] value)
    {
      this.Container.Subdomains = value;
      return this;
    }

    public MapLayerBuilder Style(Action<MapLayerStyleSettingsBuilder> configurator)
    {
      this.Container.Style.Map = this.Container.Map;
      configurator(new MapLayerStyleSettingsBuilder(this.Container.Style));
      return this;
    }

    public MapLayerBuilder UrlTemplate(string value)
    {
      this.Container.UrlTemplate = value;
      return this;
    }

    public MapLayerBuilder UrlTemplateId(string templateId)
    {
      this.Container.UrlTemplateId = templateId;
      return this;
    }

    public MapLayerBuilder ValueField(string value)
    {
      this.Container.ValueField = value;
      return this;
    }

    public MapLayerBuilder ZIndex(double value)
    {
      this.Container.ZIndex = new double?(value);
      return this;
    }

    public MapLayerBuilder Type(MapLayerType value)
    {
      this.Container.Type = new MapLayerType?(value);
      return this;
    }

    public MapLayerBuilder ImagerySet(MapLayersImagerySet value)
    {
      this.Container.ImagerySet = new MapLayersImagerySet?(value);
      return this;
    }

    public MapLayerBuilder Shape(MapMarkersShape value)
    {
      this.Container.Shape = new MapMarkersShape?(value);
      return this;
    }

    public MapLayerBuilder Symbol(MapSymbol value)
    {
      this.Container.Symbol = new MapSymbol?(value);
      return this;
    }
  }
}
