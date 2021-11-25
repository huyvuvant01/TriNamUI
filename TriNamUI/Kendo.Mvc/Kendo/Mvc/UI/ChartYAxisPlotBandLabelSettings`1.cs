// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartYAxisPlotBandLabelSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartYAxisPlotBandLabelSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Align { get; set; }

    public string Background { get; set; }

    public ChartYAxisPlotBandLabelBorderSettings<T> Border { get; } = new ChartYAxisPlotBandLabelBorderSettings<T>();

    public string Color { get; set; }

    public string Font { get; set; }

    public ChartYAxisPlotBandLabelMarginSettings<T> Margin { get; } = new ChartYAxisPlotBandLabelMarginSettings<T>();

    public ChartYAxisPlotBandLabelPaddingSettings<T> Padding { get; } = new ChartYAxisPlotBandLabelPaddingSettings<T>();

    public string Position { get; set; }

    public double? Rotation { get; set; }

    public string Text { get; set; }

    public bool? Visible { get; set; }

    public ClientHandlerDescriptor Visual { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string align = this.Align;
      if ((align != null ? (align.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["align"] = (object) this.Align;
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
      Dictionary<string, object> source2 = this.Margin.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["margin"] = (object) source2;
      Dictionary<string, object> source3 = this.Padding.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["padding"] = (object) source3;
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      if (this.Rotation.HasValue)
        dictionary["rotation"] = (object) this.Rotation;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.Visual;
      return dictionary;
    }
  }
}
