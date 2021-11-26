// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesLabelsFromSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesLabelsFromSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ClientHandlerDescriptor BackgroundHandler { get; set; }

    public ChartSeriesLabelsFromBorderSettings<T> Border { get; } = new ChartSeriesLabelsFromBorderSettings<T>();

    public string Color { get; set; }

    public ClientHandlerDescriptor ColorHandler { get; set; }

    public string Font { get; set; }

    public ClientHandlerDescriptor FontHandler { get; set; }

    public string Format { get; set; }

    public ClientHandlerDescriptor FormatHandler { get; set; }

    public ChartSeriesLabelsFromMarginSettings<T> Margin { get; } = new ChartSeriesLabelsFromMarginSettings<T>();

    public ChartSeriesLabelsFromPaddingSettings<T> Padding { get; } = new ChartSeriesLabelsFromPaddingSettings<T>();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public ClientHandlerDescriptor VisibleHandler { get; set; }

    public ChartSeriesLabelsPosition? Position { get; set; }

    public ClientHandlerDescriptor PositionHandler { get; set; }

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
      ClientHandlerDescriptor colorHandler = this.ColorHandler;
      if ((colorHandler != null ? (colorHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["color"] = (object) this.ColorHandler;
      }
      else
      {
        string color = this.Color;
        if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["color"] = (object) this.Color;
      }
      ClientHandlerDescriptor fontHandler = this.FontHandler;
      if ((fontHandler != null ? (fontHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["font"] = (object) this.FontHandler;
      }
      else
      {
        string font = this.Font;
        if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["font"] = (object) this.Font;
      }
      ClientHandlerDescriptor formatHandler = this.FormatHandler;
      if ((formatHandler != null ? (formatHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["format"] = (object) this.FormatHandler;
      }
      else
      {
        string format = this.Format;
        if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["format"] = (object) this.Format;
      }
      Dictionary<string, object> source2 = this.Margin.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["margin"] = (object) source2;
      Dictionary<string, object> source3 = this.Padding.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["padding"] = (object) source3;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Chart.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      ClientHandlerDescriptor visibleHandler = this.VisibleHandler;
      if ((visibleHandler != null ? (visibleHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["visible"] = (object) this.VisibleHandler;
      else if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      ClientHandlerDescriptor positionHandler = this.PositionHandler;
      if ((positionHandler != null ? (positionHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["position"] = (object) this.PositionHandler;
      }
      else
      {
        ChartSeriesLabelsPosition? position = this.Position;
        if (position.HasValue)
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          position = this.Position;
          ref ChartSeriesLabelsPosition? local = ref position;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["position"] = (object) str;
        }
      }
      return dictionary1;
    }
  }
}
