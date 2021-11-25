// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ExpansionPanelTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-expansionpanel")]
  [RestrictChildren("content", new string[] {"animation"})]
  public class ExpansionPanelTagHelper : TagHelperBase
  {
    public ExpansionPanelTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
            context.Items[GetType()] = this;
            (await output.GetChildContentAsync()).GetContent();
            await base.ProcessAsync(context, output);
        }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "ExpansionPanel", (IDictionary<string, object>) this.SerializeSettings());

    public string OnExpand { get; set; }

    public string OnCollapse { get; set; }

    public string OnComplete { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onExpand = this.OnExpand;
      if ((onExpand != null ? (onExpand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expand"] = (object) this.CreateHandler(this.OnExpand);
      string onCollapse = this.OnCollapse;
      if ((onCollapse != null ? (onCollapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapse"] = (object) this.CreateHandler(this.OnCollapse);
      string onComplete = this.OnComplete;
      if ((onComplete != null ? (onComplete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["complete"] = (object) this.CreateHandler(this.OnComplete);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public ExpansionPanelAnimationSettingsTagHelper Animation { get; set; }

    public string CollapseIconClass { get; set; }

    public bool? Disabled { get; set; }

    public bool? Expanded { get; set; }

    public string ExpandIconClass { get; set; }

    public double? Height { get; set; }

    public string SubTitle { get; set; }

    public string Title { get; set; }

    public bool? Toggleable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Animation.Enabled.HasValue || this.Animation.Enabled.Value))
          dictionary["animation"] = (object) source;
        else if (this.Animation.Enabled.HasValue && !this.Animation.Enabled.Value)
          dictionary["animation"] = (object) this.Animation.Enabled;
      }
      string collapseIconClass = this.CollapseIconClass;
      if ((collapseIconClass != null ? (collapseIconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapseIconClass"] = (object) this.CollapseIconClass;
      if (this.Disabled.HasValue)
        dictionary["disabled"] = (object) this.Disabled;
      if (this.Expanded.HasValue)
        dictionary["expanded"] = (object) this.Expanded;
      string expandIconClass = this.ExpandIconClass;
      if ((expandIconClass != null ? (expandIconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expandIconClass"] = (object) this.ExpandIconClass;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      string subTitle = this.SubTitle;
      if ((subTitle != null ? (subTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["subTitle"] = (object) this.SubTitle;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      if (this.Toggleable.HasValue)
        dictionary["toggleable"] = (object) this.Toggleable;
      return dictionary;
    }
  }
}
