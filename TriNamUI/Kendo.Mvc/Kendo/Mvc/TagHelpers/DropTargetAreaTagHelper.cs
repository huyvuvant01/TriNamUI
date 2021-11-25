// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropTargetAreaTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("body", Attributes = "kendo-droptargetarea")]
  [HtmlTargetElement("div", Attributes = "kendo-droptargetarea")]
  [HtmlTargetElement("form", Attributes = "kendo-droptargetarea")]
  [HtmlTargetElement("ul", Attributes = "kendo-droptargetarea")]
  [HtmlTargetElement("ol", Attributes = "kendo-droptargetarea")]
  [HtmlTargetElement("p", Attributes = "kendo-droptargetarea")]
  [HtmlTargetElement("a", Attributes = "kendo-droptargetarea")]
  [HtmlTargetElement("table", Attributes = "kendo-droptargetarea")]
  [HtmlTargetElement("nav", Attributes = "kendo-droptargetarea")]
  public class DropTargetAreaTagHelper : DropTargetTagHelper
  {
    public DropTargetAreaTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    [HtmlAttributeName("kendo-droptargetarea")]
    public override bool? IsEnabled { get; set; }

    [HtmlAttributeName("kendo-filter")]
    public string Filter { get; set; }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      if (!(output.TagName == "kendo-droptarget-area"))
        return;
      output.TagName = (string) null;
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filter"] = (object) this.Filter;
      return this.Initializer.Initialize(this.Selector, "DropTargetArea", (IDictionary<string, object>) dictionary);
    }
  }
}
