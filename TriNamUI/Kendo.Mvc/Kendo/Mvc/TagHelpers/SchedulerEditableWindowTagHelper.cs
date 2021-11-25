// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerEditableWindowTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("editable-window", ParentTag = "editable", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("popup-animation", new string[] {})]
  [SuppressTagRendering]
  public class SchedulerEditableWindowTagHelper : WindowTagHelper
  {
    public SchedulerEditableWindowTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      this.AddSelfToParent(context);
      await base.ProcessAsync(context, output);
    }

    protected void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerEditableSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerEditableSettingsTagHelper).Window = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();
  }
}
