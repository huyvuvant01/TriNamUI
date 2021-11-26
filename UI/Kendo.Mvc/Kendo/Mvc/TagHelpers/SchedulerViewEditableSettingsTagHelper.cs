// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerViewEditableSettingsTagHelper
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
  [HtmlTargetElement("editable", ParentTag = "view", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class SchedulerViewEditableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerViewTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerViewTagHelper).Editable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public bool? Create { get; set; }

    public bool? Destroy { get; set; }

    public bool? Update { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Create.HasValue)
        dictionary["create"] = (object) this.Create;
      if (this.Destroy.HasValue)
        dictionary["destroy"] = (object) this.Destroy;
      if (this.Update.HasValue)
        dictionary["update"] = (object) this.Update;
      return dictionary;
    }
  }
}
