// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartCategoryAxisLabelsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartCategoryAxisLabelsSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ChartCategoryAxisLabelsBorderSettings<T> Border { get; } = new ChartCategoryAxisLabelsBorderSettings<T>();

    public string Color { get; set; }

    public string Culture { get; set; }

    public ChartCategoryAxisLabelsDateFormatsSettings<T> DateFormats { get; } = new ChartCategoryAxisLabelsDateFormatsSettings<T>();

    public string Font { get; set; }

    public string Format { get; set; }

    public ChartCategoryAxisLabelsMarginSettings<T> Margin { get; } = new ChartCategoryAxisLabelsMarginSettings<T>();

    public bool? Mirror { get; set; }

    public ChartCategoryAxisLabelsPaddingSettings<T> Padding { get; } = new ChartCategoryAxisLabelsPaddingSettings<T>();

    public ChartCategoryAxisLabelsRotationSettings<T> Rotation { get; } = new ChartCategoryAxisLabelsRotationSettings<T>();

    public double? Skip { get; set; }

    public double? Step { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public ClientHandlerDescriptor Visual { get; set; }

    public ChartAxisLabelsPosition? Position { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

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
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["culture"] = (object) this.Culture;
      Dictionary<string, object> source2 = this.DateFormats.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["dateFormats"] = (object) source2;
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["font"] = (object) this.Font;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["format"] = (object) this.Format;
      Dictionary<string, object> source3 = this.Margin.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["margin"] = (object) source3;
      bool? nullable1 = this.Mirror;
      if (nullable1.HasValue)
        dictionary1["mirror"] = (object) this.Mirror;
      Dictionary<string, object> source4 = this.Padding.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary1["padding"] = (object) source4;
      Dictionary<string, object> source5 = this.Rotation.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary1["rotation"] = (object) source5;
      double? nullable2 = this.Skip;
      if (nullable2.HasValue)
        dictionary1["skip"] = (object) this.Skip;
      nullable2 = this.Step;
      if (nullable2.HasValue)
        dictionary1["step"] = (object) this.Step;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Chart.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      nullable1 = this.Visible;
      if (nullable1.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["visual"] = (object) this.Visual;
      ChartAxisLabelsPosition? position = this.Position;
      if (position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        position = this.Position;
        ref ChartAxisLabelsPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
