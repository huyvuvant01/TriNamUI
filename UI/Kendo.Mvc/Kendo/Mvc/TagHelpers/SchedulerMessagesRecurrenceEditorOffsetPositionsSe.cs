// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsTagHelper
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
  [HtmlTargetElement("offset-positions", ParentTag = "recurrence-editor", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerMessagesRecurrenceEditorSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerMessagesRecurrenceEditorSettingsTagHelper).OffsetPositions = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string First { get; set; }

    public string Second { get; set; }

    public string Third { get; set; }

    public string Fourth { get; set; }

    public string Last { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string first = this.First;
      if ((first != null ? (first.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["first"] = (object) this.First;
      string second = this.Second;
      if ((second != null ? (second.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["second"] = (object) this.Second;
      string third = this.Third;
      if ((third != null ? (third.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["third"] = (object) this.Third;
      string fourth = this.Fourth;
      if ((fourth != null ? (fourth.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fourth"] = (object) this.Fourth;
      string last = this.Last;
      if ((last != null ? (last.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["last"] = (object) this.Last;
      return dictionary;
    }
  }
}
