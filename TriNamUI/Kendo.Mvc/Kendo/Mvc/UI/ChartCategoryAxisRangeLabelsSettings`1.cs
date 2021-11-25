// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartCategoryAxisRangeLabelsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartCategoryAxisRangeLabelsSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ChartCategoryAxisRangeLabelsBorderSettings<T> Border { get; } = new ChartCategoryAxisRangeLabelsBorderSettings<T>();

    public string Color { get; set; }

    public string Culture { get; set; }

    public ChartCategoryAxisRangeLabelsDateFormatsSettings<T> DateFormats { get; } = new ChartCategoryAxisRangeLabelsDateFormatsSettings<T>();

    public string Font { get; set; }

    public string Format { get; set; }

    public ChartCategoryAxisRangeLabelsMarginSettings<T> Margin { get; } = new ChartCategoryAxisRangeLabelsMarginSettings<T>();

    public bool? Mirror { get; set; }

    public ChartCategoryAxisRangeLabelsPaddingSettings<T> Padding { get; } = new ChartCategoryAxisRangeLabelsPaddingSettings<T>();

    public ChartCategoryAxisRangeLabelsRotationSettings<T> Rotation { get; } = new ChartCategoryAxisRangeLabelsRotationSettings<T>();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public ClientHandlerDescriptor Visual { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

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
      bool? nullable = this.Mirror;
      if (nullable.HasValue)
        dictionary["mirror"] = (object) this.Mirror;
      Dictionary<string, object> source4 = this.Padding.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["padding"] = (object) source4;
      Dictionary<string, object> source5 = this.Rotation.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["rotation"] = (object) source5;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Chart.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      nullable = this.Visible;
      if (nullable.HasValue)
        dictionary["visible"] = (object) this.Visible;
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.Visual;
      return dictionary;
    }
  }
}
