// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.LinearGaugeScaleLabelsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class LinearGaugeScaleLabelsSettings
  {
    public double? Opacity { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      return dictionary;
    }

    public string Background { get; set; }

    public LinearGaugeScaleLabelsBorderSettings Border { get; } = new LinearGaugeScaleLabelsBorderSettings();

    public string Color { get; set; }

    public string Font { get; set; }

    public string Format { get; set; }

    public LinearGaugeScaleLabelsMarginSettings Margin { get; } = new LinearGaugeScaleLabelsMarginSettings();

    public LinearGaugeScaleLabelsPaddingSettings Padding { get; } = new LinearGaugeScaleLabelsPaddingSettings();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public LinearGauge LinearGauge { get; set; }

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
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["font"] = (object) this.Font;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      Dictionary<string, object> source2 = this.Margin.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["margin"] = (object) source2;
      Dictionary<string, object> source3 = this.Padding.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["padding"] = (object) source3;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.LinearGauge.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
