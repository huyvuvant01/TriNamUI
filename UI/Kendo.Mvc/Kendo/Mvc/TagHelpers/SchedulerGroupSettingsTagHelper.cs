// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerGroupSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("group", ParentTag = "kendo-scheduler", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("resources", new string[] {})]
  [SuppressTagRendering]
  public class SchedulerGroupSettingsTagHelper : TagHelperChildBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    SchedulerGroupResourcesTagHelper Resources { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerTagHelper).Group = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Resources != null)
      {
        IEnumerable<string> source = this.Resources.Select<SchedulerGroupResourceTagHelper, string>((Func<SchedulerGroupResourceTagHelper, string>) (i => i.Name));
        if (source.Any<string>())
          dictionary["resources"] = (object) source;
      }
      return dictionary;
    }

    public bool? Date { get; set; }

    public string Orientation { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Date.HasValue)
        dictionary["date"] = (object) this.Date;
      string orientation = this.Orientation;
      if ((orientation != null ? (orientation.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["orientation"] = (object) this.Orientation;
      return dictionary;
    }
  }
}
