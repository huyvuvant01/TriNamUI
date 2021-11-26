// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartValueAxisNotesLabelSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartValueAxisNotesLabelSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ChartValueAxisNotesLabelBorderSettings<T> Border { get; } = new ChartValueAxisNotesLabelBorderSettings<T>();

    public string Color { get; set; }

    public string Font { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public double? Rotation { get; set; }

    public string Format { get; set; }

    public ChartNoteLabelPosition? Position { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      Dictionary<string, object> source = this.Border.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["border"] = (object) source;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["font"] = (object) this.Font;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Chart.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      if (this.Rotation.HasValue)
        dictionary1["rotation"] = (object) this.Rotation;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["format"] = (object) this.Format;
      ChartNoteLabelPosition? position = this.Position;
      if (position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        position = this.Position;
        ref ChartNoteLabelPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
