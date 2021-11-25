// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetSheetRowCell
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SpreadsheetSheetRowCell
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public SpreadsheetSheetRowCellBorderBottomSettings BorderBottom { get; } = new SpreadsheetSheetRowCellBorderBottomSettings();

    public SpreadsheetSheetRowCellBorderLeftSettings BorderLeft { get; } = new SpreadsheetSheetRowCellBorderLeftSettings();

    public SpreadsheetSheetRowCellBorderTopSettings BorderTop { get; } = new SpreadsheetSheetRowCellBorderTopSettings();

    public SpreadsheetSheetRowCellBorderRightSettings BorderRight { get; } = new SpreadsheetSheetRowCellBorderRightSettings();

    public string Color { get; set; }

    public string Comment { get; set; }

    public string FontFamily { get; set; }

    public double? FontSize { get; set; }

    public bool? Italic { get; set; }

    public bool? Bold { get; set; }

    public bool? Enable { get; set; }

    public string Format { get; set; }

    public string Formula { get; set; }

    public bool? Html { get; set; }

    public int? Index { get; set; }

    public string Link { get; set; }

    public bool? Underline { get; set; }

    public object Value { get; set; }

    public SpreadsheetSheetRowCellValidationSettings Validation { get; } = new SpreadsheetSheetRowCellValidationSettings();

    public bool? Wrap { get; set; }

    public SpreadsheetTextAlign? TextAlign { get; set; }

    public SpreadsheetVerticalAlign? VerticalAlign { get; set; }

    public Spreadsheet Spreadsheet { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      Dictionary<string, object> source1 = this.BorderBottom.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["borderBottom"] = (object) source1;
      Dictionary<string, object> source2 = this.BorderLeft.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["borderLeft"] = (object) source2;
      Dictionary<string, object> source3 = this.BorderTop.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["borderTop"] = (object) source3;
      Dictionary<string, object> source4 = this.BorderRight.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary1["borderRight"] = (object) source4;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      string comment = this.Comment;
      if ((comment != null ? (comment.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["comment"] = (object) this.Comment;
      string fontFamily = this.FontFamily;
      if ((fontFamily != null ? (fontFamily.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["fontFamily"] = (object) this.FontFamily;
      if (this.FontSize.HasValue)
        dictionary1["fontSize"] = (object) this.FontSize;
      bool? nullable = this.Italic;
      if (nullable.HasValue)
        dictionary1["italic"] = (object) this.Italic;
      nullable = this.Bold;
      if (nullable.HasValue)
        dictionary1["bold"] = (object) this.Bold;
      nullable = this.Enable;
      if (nullable.HasValue)
        dictionary1["enable"] = (object) this.Enable;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["format"] = (object) this.Format;
      string formula = this.Formula;
      if ((formula != null ? (formula.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["formula"] = (object) this.Formula;
      nullable = this.Html;
      if (nullable.HasValue)
        dictionary1["html"] = (object) this.Html;
      if (this.Index.HasValue)
        dictionary1["index"] = (object) this.Index;
      string link = this.Link;
      if ((link != null ? (link.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["link"] = (object) this.Link;
      nullable = this.Underline;
      if (nullable.HasValue)
        dictionary1["underline"] = (object) this.Underline;
      if (this.Value != null)
        dictionary1["value"] = this.Value;
      Dictionary<string, object> source5 = this.Validation.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary1["validation"] = (object) source5;
      nullable = this.Wrap;
      if (nullable.HasValue)
        dictionary1["wrap"] = (object) this.Wrap;
      SpreadsheetTextAlign? textAlign = this.TextAlign;
      if (textAlign.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        textAlign = this.TextAlign;
        ref SpreadsheetTextAlign? local = ref textAlign;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["textAlign"] = (object) str;
      }
      SpreadsheetVerticalAlign? verticalAlign = this.VerticalAlign;
      if (verticalAlign.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        verticalAlign = this.VerticalAlign;
        ref SpreadsheetVerticalAlign? local = ref verticalAlign;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["verticalAlign"] = (object) str;
      }
      return dictionary1;
    }
  }
}
