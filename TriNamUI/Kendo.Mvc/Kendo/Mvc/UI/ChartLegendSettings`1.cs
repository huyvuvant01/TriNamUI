// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartLegendSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartLegendSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ChartLegendBorderSettings<T> Border { get; } = new ChartLegendBorderSettings<T>();

    public double? Height { get; set; }

    public ChartLegendInactiveItemsSettings<T> InactiveItems { get; } = new ChartLegendInactiveItemsSettings<T>();

    public ChartLegendItemSettings<T> Item { get; } = new ChartLegendItemSettings<T>();

    public ChartLegendLabelsSettings<T> Labels { get; } = new ChartLegendLabelsSettings<T>();

    public ChartLegendMarginSettings<T> Margin { get; } = new ChartLegendMarginSettings<T>();

    public double? OffsetX { get; set; }

    public double? OffsetY { get; set; }

    public ChartLegendPaddingSettings<T> Padding { get; } = new ChartLegendPaddingSettings<T>();

    public bool? Reverse { get; set; }

    public double? Spacing { get; set; }

    public ChartLegendTitleSettings<T> Title { get; } = new ChartLegendTitleSettings<T>();

    public bool? Visible { get; set; }

    public double? Width { get; set; }

    public ChartLegendAlign? Align { get; set; }

    public ChartLegendOrientation? Orientation { get; set; }

    public ChartLegendPosition? Position { get; set; }

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
      double? nullable1 = this.Height;
      if (nullable1.HasValue)
        dictionary1["height"] = (object) this.Height;
      Dictionary<string, object> source2 = this.InactiveItems.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["inactiveItems"] = (object) source2;
      Dictionary<string, object> source3 = this.Item.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["item"] = (object) source3;
      Dictionary<string, object> source4 = this.Labels.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary1["labels"] = (object) source4;
      Dictionary<string, object> source5 = this.Margin.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary1["margin"] = (object) source5;
      nullable1 = this.OffsetX;
      if (nullable1.HasValue)
        dictionary1["offsetX"] = (object) this.OffsetX;
      nullable1 = this.OffsetY;
      if (nullable1.HasValue)
        dictionary1["offsetY"] = (object) this.OffsetY;
      Dictionary<string, object> source6 = this.Padding.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary1["padding"] = (object) source6;
      bool? nullable2 = this.Reverse;
      if (nullable2.HasValue)
        dictionary1["reverse"] = (object) this.Reverse;
      nullable1 = this.Spacing;
      if (nullable1.HasValue)
        dictionary1["spacing"] = (object) this.Spacing;
      Dictionary<string, object> source7 = this.Title.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary1["title"] = (object) source7;
      nullable2 = this.Visible;
      if (nullable2.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      nullable1 = this.Width;
      if (nullable1.HasValue)
        dictionary1["width"] = (object) this.Width;
      ChartLegendAlign? align = this.Align;
      if (align.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        align = this.Align;
        ref ChartLegendAlign? local = ref align;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["align"] = (object) str;
      }
      ChartLegendOrientation? orientation = this.Orientation;
      if (orientation.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        orientation = this.Orientation;
        ref ChartLegendOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["orientation"] = (object) str;
      }
      ChartLegendPosition? position = this.Position;
      if (position.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        position = this.Position;
        ref ChartLegendPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
