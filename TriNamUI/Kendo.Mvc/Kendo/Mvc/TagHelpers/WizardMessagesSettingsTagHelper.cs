// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.WizardMessagesSettingsTagHelper
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
  [HtmlTargetElement("messages", ParentTag = "kendo-wizard", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class WizardMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (WizardTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as WizardTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Done { get; set; }

    public string Next { get; set; }

    public string Of { get; set; }

    public string Previous { get; set; }

    public string Reset { get; set; }

    public string Step { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string done = this.Done;
      if ((done != null ? (done.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["done"] = (object) this.Done;
      string next = this.Next;
      if ((next != null ? (next.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["next"] = (object) this.Next;
      string of = this.Of;
      if ((of != null ? (of.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["of"] = (object) this.Of;
      string previous = this.Previous;
      if ((previous != null ? (previous.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["previous"] = (object) this.Previous;
      string reset = this.Reset;
      if ((reset != null ? (reset.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["reset"] = (object) this.Reset;
      string step = this.Step;
      if ((step != null ? (step.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["step"] = (object) this.Step;
      return dictionary;
    }
  }
}
