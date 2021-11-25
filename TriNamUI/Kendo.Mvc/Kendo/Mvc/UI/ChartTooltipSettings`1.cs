// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartTooltipSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartTooltipSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? AutoHide { get; set; }

    public string Background { get; set; }

    public ChartTooltipBorderSettings<T> Border { get; } = new ChartTooltipBorderSettings<T>();

    public string Color { get; set; }

    public string Font { get; set; }

    public string Format { get; set; }

    public double? Opacity { get; set; }

    public ChartTooltipPaddingSettings<T> Padding { get; } = new ChartTooltipPaddingSettings<T>();

    public bool? Shared { get; set; }

    public string SharedTemplate { get; set; }

    public string SharedTemplateId { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.AutoHide.HasValue)
        dictionary["autoHide"] = (object) this.AutoHide;
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
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      Dictionary<string, object> source2 = this.Padding.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["padding"] = (object) source2;
      if (this.Shared.HasValue)
        dictionary["shared"] = (object) this.Shared;
      if (this.SharedTemplateId.HasValue())
        dictionary["sharedTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Chart.IdPrefix, (object) this.SharedTemplateId)
        };
      else if (this.SharedTemplate.HasValue())
        dictionary["sharedTemplate"] = (object) this.SharedTemplate;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Chart.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
