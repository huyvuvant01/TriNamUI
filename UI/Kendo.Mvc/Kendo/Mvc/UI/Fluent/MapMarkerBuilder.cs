// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapMarkerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapMarkerBuilder
  {
    public MapMarkerBuilder(MapMarker container) => this.Container = container;

    protected MapMarker Container { get; private set; }

    public virtual MapMarkerBuilder HtmlAttributes(object attributes) => this.HtmlAttributes(attributes.ToDictionary());

    public virtual MapMarkerBuilder HtmlAttributes(
      IDictionary<string, object> attributes)
    {
      this.Container.HtmlAttributes.Clear();
      DictionaryExtensions.Merge(this.Container.HtmlAttributes, attributes);
      return this;
    }

    public MapMarkerBuilder Shape(string name)
    {
      this.Container.ShapeName = name;
      return this;
    }

    public MapMarkerBuilder Tooltip(Action<MapMarkerTooltipBuilder> configurator)
    {
      configurator(new MapMarkerTooltipBuilder(this.Container.Tooltip));
      return this;
    }

    public MapMarkerBuilder Location(params double[] value)
    {
      this.Container.Location = value;
      return this;
    }

    public MapMarkerBuilder Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public MapMarkerBuilder Shape(MapMarkersShape value)
    {
      this.Container.Shape = new MapMarkersShape?(value);
      return this;
    }
  }
}
