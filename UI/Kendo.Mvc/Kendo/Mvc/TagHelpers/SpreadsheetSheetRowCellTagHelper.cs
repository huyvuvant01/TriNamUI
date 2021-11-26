// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetSheetRowCellTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("cell", ParentTag = "cells", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border-bottom", new string[] {"border-left", "border-top", "border-right", "validation"})]
  [SuppressTagRendering]
  public class SpreadsheetSheetRowCellTagHelper : TagHelperCollectionItemBase
  {
    private 
    #nullable disable
    object ParsedValue;

    public string Value { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      if (this.Value != null)
      {
        double result1;
        bool result2;
        DateTime result3;
        this.ParsedValue = !double.TryParse(this.Value, out result1) ? (!bool.TryParse(this.Value, out result2) ? (!DateTime.TryParse(this.Value, out result3) ? (object) this.Value : (object) result3) : (object) result2) : (object) result1;
      }
      await base.ProcessAsync(context, output);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SpreadsheetSheetRowCellsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetSheetRowCellsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.ParsedValue != null)
        dictionary["value"] = this.ParsedValue;
      return dictionary;
    }

    public string Background { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetRowCellBorderBottomSettingsTagHelper BorderBottom { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetRowCellBorderLeftSettingsTagHelper BorderLeft { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetRowCellBorderTopSettingsTagHelper BorderTop { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetRowCellBorderRightSettingsTagHelper BorderRight { get; set; }

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

    public double? Index { get; set; }

    public string Link { get; set; }

    public bool? Underline { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetRowCellValidationSettingsTagHelper Validation { get; set; }

    public bool? Wrap { get; set; }

    public SpreadsheetTextAlign? TextAlign { get; set; }

    public SpreadsheetVerticalAlign? VerticalAlign { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      if (this.BorderBottom != null)
      {
        Dictionary<string, object> source = this.BorderBottom.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["borderBottom"] = (object) source;
      }
      if (this.BorderLeft != null)
      {
        Dictionary<string, object> source = this.BorderLeft.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["borderLeft"] = (object) source;
      }
      if (this.BorderTop != null)
      {
        Dictionary<string, object> source = this.BorderTop.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["borderTop"] = (object) source;
      }
      if (this.BorderRight != null)
      {
        Dictionary<string, object> source = this.BorderRight.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["borderRight"] = (object) source;
      }
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      string comment = this.Comment;
      if ((comment != null ? (comment.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["comment"] = (object) this.Comment;
      string fontFamily = this.FontFamily;
      if ((fontFamily != null ? (fontFamily.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["fontFamily"] = (object) this.FontFamily;
      double? nullable1 = this.FontSize;
      if (nullable1.HasValue)
        dictionary1["fontSize"] = (object) this.FontSize;
      bool? nullable2 = this.Italic;
      if (nullable2.HasValue)
        dictionary1["italic"] = (object) this.Italic;
      nullable2 = this.Bold;
      if (nullable2.HasValue)
        dictionary1["bold"] = (object) this.Bold;
      nullable2 = this.Enable;
      if (nullable2.HasValue)
        dictionary1["enable"] = (object) this.Enable;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["format"] = (object) this.Format;
      string formula = this.Formula;
      if ((formula != null ? (formula.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["formula"] = (object) this.Formula;
      nullable2 = this.Html;
      if (nullable2.HasValue)
        dictionary1["html"] = (object) this.Html;
      nullable1 = this.Index;
      if (nullable1.HasValue)
        dictionary1["index"] = (object) this.Index;
      string link = this.Link;
      if ((link != null ? (link.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["link"] = (object) this.Link;
      nullable2 = this.Underline;
      if (nullable2.HasValue)
        dictionary1["underline"] = (object) this.Underline;
      if (this.Validation != null)
      {
        Dictionary<string, object> source = this.Validation.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["validation"] = (object) source;
      }
      nullable2 = this.Wrap;
      if (nullable2.HasValue)
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
