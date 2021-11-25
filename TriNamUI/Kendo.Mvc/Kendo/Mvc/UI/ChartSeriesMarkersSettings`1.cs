// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesMarkersSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesMarkersSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ClientHandlerDescriptor BackgroundHandler { get; set; }

    public ChartSeriesMarkersBorderSettings<T> Border { get; } = new ChartSeriesMarkersBorderSettings<T>();

    public double? BorderRadius { get; set; }

    public ChartSeriesMarkersFromSettings<T> From { get; } = new ChartSeriesMarkersFromSettings<T>();

    public double? Size { get; set; }

    public ClientHandlerDescriptor SizeHandler { get; set; }

    public ChartSeriesMarkersToSettings<T> To { get; } = new ChartSeriesMarkersToSettings<T>();

    public bool? Visible { get; set; }

    public ClientHandlerDescriptor VisibleHandler { get; set; }

    public ClientHandlerDescriptor Visual { get; set; }

    public double? Rotation { get; set; }

    public ClientHandlerDescriptor RotationHandler { get; set; }

    public double? ZIndex { get; set; }

    public ClientHandlerDescriptor ZIndexHandler { get; set; }

    public ChartMarkerShape? Type { get; set; }

    public ClientHandlerDescriptor TypeHandler { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      ClientHandlerDescriptor backgroundHandler = this.BackgroundHandler;
      if ((backgroundHandler != null ? (backgroundHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["background"] = (object) this.BackgroundHandler;
      }
      else
      {
        string background = this.Background;
        if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["background"] = (object) this.Background;
      }
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["border"] = (object) source1;
      double? nullable = this.BorderRadius;
      if (nullable.HasValue)
        dictionary1["borderRadius"] = (object) this.BorderRadius;
      Dictionary<string, object> source2 = this.From.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["from"] = (object) source2;
      ClientHandlerDescriptor sizeHandler = this.SizeHandler;
      if ((sizeHandler != null ? (sizeHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["size"] = (object) this.SizeHandler;
      }
      else
      {
        nullable = this.Size;
        if (nullable.HasValue)
          dictionary1["size"] = (object) this.Size;
      }
      Dictionary<string, object> source3 = this.To.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["to"] = (object) source3;
      ClientHandlerDescriptor visibleHandler = this.VisibleHandler;
      if ((visibleHandler != null ? (visibleHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["visible"] = (object) this.VisibleHandler;
      else if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["visual"] = (object) this.Visual;
      ClientHandlerDescriptor rotationHandler = this.RotationHandler;
      if ((rotationHandler != null ? (rotationHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["rotation"] = (object) this.RotationHandler;
      }
      else
      {
        nullable = this.Rotation;
        if (nullable.HasValue)
          dictionary1["rotation"] = (object) this.Rotation;
      }
      ClientHandlerDescriptor zindexHandler = this.ZIndexHandler;
      if ((zindexHandler != null ? (zindexHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["zIndex"] = (object) this.ZIndexHandler;
      }
      else
      {
        nullable = this.ZIndex;
        if (nullable.HasValue)
          dictionary1["zIndex"] = (object) this.ZIndex;
      }
      ClientHandlerDescriptor typeHandler = this.TypeHandler;
      if ((typeHandler != null ? (typeHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["type"] = (object) this.TypeHandler;
      }
      else
      {
        ChartMarkerShape? type = this.Type;
        if (type.HasValue)
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          type = this.Type;
          ref ChartMarkerShape? local = ref type;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["type"] = (object) str;
        }
      }
      return dictionary1;
    }
  }
}
