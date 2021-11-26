// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PanelBarMessagesSettingsTagHelper
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
  [HtmlTargetElement("messages", ParentTag = "kendo-panelbar", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class PanelBarMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PanelBarTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PanelBarTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Loading { get; set; }

    public string RequestFailed { get; set; }

    public string Retry { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string loading = this.Loading;
      if ((loading != null ? (loading.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["loading"] = (object) this.Loading;
      string requestFailed = this.RequestFailed;
      if ((requestFailed != null ? (requestFailed.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["requestFailed"] = (object) this.RequestFailed;
      string retry = this.Retry;
      if ((retry != null ? (retry.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["retry"] = (object) this.Retry;
      return dictionary;
    }
  }
}
