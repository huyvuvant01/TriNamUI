﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StockChartNavigatorSeriesLabelsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class StockChartNavigatorSeriesLabelsSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public StockChartNavigatorSeriesLabelsBorderSettings<T> Border { get; } = new StockChartNavigatorSeriesLabelsBorderSettings<T>();

    public string Color { get; set; }

    public string Font { get; set; }

    public string Format { get; set; }

    public double? Margin { get; set; }

    public double? Padding { get; set; }

    public string Position { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public Kendo.Mvc.UI.StockChart<T> StockChart { get; set; }

    protected Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      Dictionary<string, object> source = this.Border.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["border"] = (object) source;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["font"] = (object) this.Font;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      double? nullable = this.Margin;
      if (nullable.HasValue)
        dictionary["margin"] = (object) this.Margin;
      nullable = this.Padding;
      if (nullable.HasValue)
        dictionary["padding"] = (object) this.Padding;
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.StockChart.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
