// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropTargetTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("body", Attributes = "kendo-droptarget")]
  [HtmlTargetElement("div", Attributes = "kendo-droptarget")]
  [HtmlTargetElement("form", Attributes = "kendo-droptarget")]
  [HtmlTargetElement("ul", Attributes = "kendo-droptarget")]
  [HtmlTargetElement("ol", Attributes = "kendo-droptarget")]
  [HtmlTargetElement("p", Attributes = "kendo-droptarget")]
  [HtmlTargetElement("a", Attributes = "kendo-droptarget")]
  [HtmlTargetElement("table", Attributes = "kendo-droptarget")]
  [HtmlTargetElement("nav", Attributes = "kendo-droptarget")]
  public class DropTargetTagHelper : TagHelperBase
  {
    public DropTargetTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    [HtmlAttributeName("kendo-droptarget")]
    public virtual bool? IsEnabled { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DropTargetTagHelper dropTargetTagHelper = this;
      if (dropTargetTagHelper.IsEnabled.HasValue && !dropTargetTagHelper.IsEnabled.Value)
        return;
      context.Items[(object) dropTargetTagHelper.GetType()] = (object) dropTargetTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await dropTargetTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.MergeAttributes(tag);
      if (!(output.TagName == "kendo-droptarget"))
        return;
      output.TagName = (string) null;
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "DropTarget", (IDictionary<string, object>) this.SerializeSettings());

    [HtmlAttributeName("on-kendo-dragenter")]
    public string OnDragenter { get; set; }

    [HtmlAttributeName("on-kendo-dragleave")]
    public string OnDragleave { get; set; }

    [HtmlAttributeName("on-kendo-drop")]
    public string OnDrop { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onDragenter = this.OnDragenter;
      if ((onDragenter != null ? (onDragenter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragenter"] = (object) this.CreateHandler(this.OnDragenter);
      string onDragleave = this.OnDragleave;
      if ((onDragleave != null ? (onDragleave.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragleave"] = (object) this.CreateHandler(this.OnDragleave);
      string onDrop = this.OnDrop;
      if ((onDrop != null ? (onDrop.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["drop"] = (object) this.CreateHandler(this.OnDrop);
      return dictionary;
    }

    [HtmlAttributeName("kendo-group")]
    public string Group { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      string group = this.Group;
      if ((group != null ? (group.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["group"] = (object) this.Group;
      return dictionary;
    }
  }
}
