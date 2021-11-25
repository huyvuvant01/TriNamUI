// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StockChartNavigatorCategoryAxisLabelsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class StockChartNavigatorCategoryAxisLabelsSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public StockChartNavigatorCategoryAxisLabelsBorderSettings<T> Border { get; } = new StockChartNavigatorCategoryAxisLabelsBorderSettings<T>();

    public string Color { get; set; }

    public string Culture { get; set; }

    public StockChartNavigatorCategoryAxisLabelsDateFormatsSettings<T> DateFormats { get; } = new StockChartNavigatorCategoryAxisLabelsDateFormatsSettings<T>();

    public string Font { get; set; }

    public string Format { get; set; }

    public StockChartNavigatorCategoryAxisLabelsMarginSettings<T> Margin { get; } = new StockChartNavigatorCategoryAxisLabelsMarginSettings<T>();

    public bool? Mirror { get; set; }

    public StockChartNavigatorCategoryAxisLabelsPaddingSettings<T> Padding { get; } = new StockChartNavigatorCategoryAxisLabelsPaddingSettings<T>();

    public double? Rotation { get; set; }

    public double? Skip { get; set; }

    public double? Step { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public Kendo.Mvc.UI.StockChart<T> StockChart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["border"] = (object) source1;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["culture"] = (object) this.Culture;
      Dictionary<string, object> source2 = this.DateFormats.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["dateFormats"] = (object) source2;
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["font"] = (object) this.Font;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      Dictionary<string, object> source3 = this.Margin.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["margin"] = (object) source3;
      bool? nullable1 = this.Mirror;
      if (nullable1.HasValue)
        dictionary["mirror"] = (object) this.Mirror;
      Dictionary<string, object> source4 = this.Padding.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["padding"] = (object) source4;
      double? nullable2 = this.Rotation;
      if (nullable2.HasValue)
        dictionary["rotation"] = (object) this.Rotation;
      nullable2 = this.Skip;
      if (nullable2.HasValue)
        dictionary["skip"] = (object) this.Skip;
      nullable2 = this.Step;
      if (nullable2.HasValue)
        dictionary["step"] = (object) this.Step;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.StockChart.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      nullable1 = this.Visible;
      if (nullable1.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
