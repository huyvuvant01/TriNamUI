// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartCategoryAxisAutoBaseUnitStepsSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("auto-base-unit-steps", ParentTag = "category-axis-item", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ChartCategoryAxisAutoBaseUnitStepsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartCategoryAxisTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartCategoryAxisTagHelper).AutoBaseUnitSteps = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public int[] Milliseconds { get; set; }

    public int[] Seconds { get; set; }

    public int[] Minutes { get; set; }

    public int[] Hours { get; set; }

    public int[] Days { get; set; }

    public int[] Weeks { get; set; }

    public int[] Months { get; set; }

    public int[] Years { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      int[] milliseconds = this.Milliseconds;
      if ((milliseconds != null ? (((IEnumerable<int>) milliseconds).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["milliseconds"] = (object) this.Milliseconds;
      int[] seconds = this.Seconds;
      if ((seconds != null ? (((IEnumerable<int>) seconds).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["seconds"] = (object) this.Seconds;
      int[] minutes = this.Minutes;
      if ((minutes != null ? (((IEnumerable<int>) minutes).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["minutes"] = (object) this.Minutes;
      int[] hours = this.Hours;
      if ((hours != null ? (((IEnumerable<int>) hours).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["hours"] = (object) this.Hours;
      int[] days = this.Days;
      if ((days != null ? (((IEnumerable<int>) days).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["days"] = (object) this.Days;
      int[] weeks = this.Weeks;
      if ((weeks != null ? (((IEnumerable<int>) weeks).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["weeks"] = (object) this.Weeks;
      int[] months = this.Months;
      if ((months != null ? (((IEnumerable<int>) months).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["months"] = (object) this.Months;
      int[] years = this.Years;
      if ((years != null ? (((IEnumerable<int>) years).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["years"] = (object) this.Years;
      return dictionary;
    }
  }
}
