// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FormMessagesSettingsTagHelper
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
  [HtmlTargetElement("messages", ParentTag = "kendo-form", TagStructure = TagStructure.WithoutEndTag)]
  [HtmlTargetElement("messages", ParentTag = "wizard-step-form", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class FormMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FormTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FormTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Submit { get; set; }

    public string Clear { get; set; }

    public string Optional { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string submit = this.Submit;
      if ((submit != null ? (submit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["submit"] = (object) this.Submit;
      string clear = this.Clear;
      if ((clear != null ? (clear.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clear"] = (object) this.Clear;
      string optional = this.Optional;
      if ((optional != null ? (optional.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["optional"] = (object) this.Optional;
      return dictionary;
    }
  }
}
