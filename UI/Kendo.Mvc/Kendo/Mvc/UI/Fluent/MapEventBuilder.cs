// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MapEventBuilder : EventBuilder
  {
    public MapEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public MapEventBuilder BeforeReset(string handler)
    {
      this.Handler("beforeReset", handler);
      return this;
    }

    public MapEventBuilder BeforeReset(Func<object, object> handler)
    {
      this.Handler("beforeReset", handler);
      return this;
    }

    public MapEventBuilder Click(string handler)
    {
      this.Handler("click", handler);
      return this;
    }

    public MapEventBuilder Click(Func<object, object> handler)
    {
      this.Handler("click", handler);
      return this;
    }

    public MapEventBuilder MarkerActivate(string handler)
    {
      this.Handler("markerActivate", handler);
      return this;
    }

    public MapEventBuilder MarkerActivate(Func<object, object> handler)
    {
      this.Handler("markerActivate", handler);
      return this;
    }

    public MapEventBuilder MarkerCreated(string handler)
    {
      this.Handler("markerCreated", handler);
      return this;
    }

    public MapEventBuilder MarkerCreated(Func<object, object> handler)
    {
      this.Handler("markerCreated", handler);
      return this;
    }

    public MapEventBuilder MarkerClick(string handler)
    {
      this.Handler("markerClick", handler);
      return this;
    }

    public MapEventBuilder MarkerClick(Func<object, object> handler)
    {
      this.Handler("markerClick", handler);
      return this;
    }

    public MapEventBuilder Pan(string handler)
    {
      this.Handler("pan", handler);
      return this;
    }

    public MapEventBuilder Pan(Func<object, object> handler)
    {
      this.Handler("pan", handler);
      return this;
    }

    public MapEventBuilder PanEnd(string handler)
    {
      this.Handler("panEnd", handler);
      return this;
    }

    public MapEventBuilder PanEnd(Func<object, object> handler)
    {
      this.Handler("panEnd", handler);
      return this;
    }

    public MapEventBuilder Reset(string handler)
    {
      this.Handler("reset", handler);
      return this;
    }

    public MapEventBuilder Reset(Func<object, object> handler)
    {
      this.Handler("reset", handler);
      return this;
    }

    public MapEventBuilder ShapeClick(string handler)
    {
      this.Handler("shapeClick", handler);
      return this;
    }

    public MapEventBuilder ShapeClick(Func<object, object> handler)
    {
      this.Handler("shapeClick", handler);
      return this;
    }

    public MapEventBuilder ShapeCreated(string handler)
    {
      this.Handler("shapeCreated", handler);
      return this;
    }

    public MapEventBuilder ShapeCreated(Func<object, object> handler)
    {
      this.Handler("shapeCreated", handler);
      return this;
    }

    public MapEventBuilder ShapeFeatureCreated(string handler)
    {
      this.Handler("shapeFeatureCreated", handler);
      return this;
    }

    public MapEventBuilder ShapeFeatureCreated(Func<object, object> handler)
    {
      this.Handler("shapeFeatureCreated", handler);
      return this;
    }

    public MapEventBuilder ShapeMouseEnter(string handler)
    {
      this.Handler("shapeMouseEnter", handler);
      return this;
    }

    public MapEventBuilder ShapeMouseEnter(Func<object, object> handler)
    {
      this.Handler("shapeMouseEnter", handler);
      return this;
    }

    public MapEventBuilder ShapeMouseLeave(string handler)
    {
      this.Handler("shapeMouseLeave", handler);
      return this;
    }

    public MapEventBuilder ShapeMouseLeave(Func<object, object> handler)
    {
      this.Handler("shapeMouseLeave", handler);
      return this;
    }

    public MapEventBuilder ZoomStart(string handler)
    {
      this.Handler("zoomStart", handler);
      return this;
    }

    public MapEventBuilder ZoomStart(Func<object, object> handler)
    {
      this.Handler("zoomStart", handler);
      return this;
    }

    public MapEventBuilder ZoomEnd(string handler)
    {
      this.Handler("zoomEnd", handler);
      return this;
    }

    public MapEventBuilder ZoomEnd(Func<object, object> handler)
    {
      this.Handler("zoomEnd", handler);
      return this;
    }
  }
}
