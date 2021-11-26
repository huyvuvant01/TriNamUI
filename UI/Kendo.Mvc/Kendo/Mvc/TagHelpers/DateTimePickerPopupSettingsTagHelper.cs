// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DateTimePickerPopupSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("popup", ParentTag = "kendo-datetimepicker", TagStructure = TagStructure.WithoutEndTag)]
  [HtmlTargetElement("popup", ParentTag = "datetimepicker-editor", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class DateTimePickerPopupSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DateTimePickerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DateTimePickerTagHelper).Popup = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string AppendTo { get; set; }

    public string Origin { get; set; }

    public string Position { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string appendTo = this.AppendTo;
      if ((appendTo != null ? (appendTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["appendTo"] = (object) this.AppendTo;
      string origin = this.Origin;
      if ((origin != null ? (origin.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["origin"] = (object) this.Origin;
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      return dictionary;
    }
  }
}
