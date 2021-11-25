﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ArcGaugeScaleLabelsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ArcGaugeScaleLabelsSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ArcGaugeScaleLabelsBorderSettings Border { get; } = new ArcGaugeScaleLabelsBorderSettings();

    public string Color { get; set; }

    public string Font { get; set; }

    public string Format { get; set; }

    public ArcGaugeScaleLabelsMarginSettings Margin { get; } = new ArcGaugeScaleLabelsMarginSettings();

    public ArcGaugeScaleLabelsPaddingSettings Padding { get; } = new ArcGaugeScaleLabelsPaddingSettings();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public ArcGaugeScaleLabelsPosition? Position { get; set; }

    public ArcGauge ArcGauge { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["border"] = (object) source1;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["font"] = (object) this.Font;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["format"] = (object) this.Format;
      Dictionary<string, object> source2 = this.Margin.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["margin"] = (object) source2;
      Dictionary<string, object> source3 = this.Padding.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["padding"] = (object) source3;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.ArcGauge.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      ArcGaugeScaleLabelsPosition? position = this.Position;
      if (position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        position = this.Position;
        ref ArcGaugeScaleLabelsPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
