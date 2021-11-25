// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DateRangePickerRangeSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("range", ParentTag = "kendo-daterangepicker", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class DateRangePickerRangeSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DateRangePickerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DateRangePickerTagHelper).Range = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public DateTime? Start { get; set; }

    public DateTime? End { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Start.HasValue)
        dictionary["start"] = (object) this.Start;
      if (this.End.HasValue)
        dictionary["end"] = (object) this.End;
      return dictionary;
    }
  }
}
