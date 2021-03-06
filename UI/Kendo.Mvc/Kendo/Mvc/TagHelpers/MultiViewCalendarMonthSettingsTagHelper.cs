// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MultiViewCalendarMonthSettingsTagHelper
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
  [HtmlTargetElement("month", ParentTag = "kendo-multiviewcalendar", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class MultiViewCalendarMonthSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (MultiViewCalendarTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as MultiViewCalendarTagHelper).Month = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Content { get; set; }

    public string WeekNumber { get; set; }

    public string Empty { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["content"] = (object) this.Content;
      string weekNumber = this.WeekNumber;
      if ((weekNumber != null ? (weekNumber.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["weekNumber"] = (object) this.WeekNumber;
      string empty = this.Empty;
      if ((empty != null ? (empty.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["empty"] = (object) this.Empty;
      return dictionary;
    }
  }
}
