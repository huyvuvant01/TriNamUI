// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartTitleSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartTitleSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ChartTitleBorderSettings<T> Border { get; } = new ChartTitleBorderSettings<T>();

    public string Color { get; set; }

    public string Font { get; set; }

    public ChartTitleMarginSettings<T> Margin { get; } = new ChartTitleMarginSettings<T>();

    public ChartTitlePaddingSettings<T> Padding { get; } = new ChartTitlePaddingSettings<T>();

    public string Text { get; set; }

    public bool? Visible { get; set; }

    public ChartTextAlignment? Align { get; set; }

    public ChartTitlePosition? Position { get; set; }

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
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["font"] = (object) this.Font;
      Dictionary<string, object> source2 = this.Margin.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["margin"] = (object) source2;
      Dictionary<string, object> source3 = this.Padding.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["padding"] = (object) source3;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      ChartTextAlignment? align = this.Align;
      if (align.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        align = this.Align;
        ref ChartTextAlignment? local = ref align;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["align"] = (object) str;
      }
      ChartTitlePosition? position = this.Position;
      if (position.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        position = this.Position;
        ref ChartTitlePosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
