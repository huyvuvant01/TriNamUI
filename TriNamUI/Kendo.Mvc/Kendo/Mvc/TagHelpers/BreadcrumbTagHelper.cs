// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.BreadcrumbTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-breadcrumb")]
  [RestrictChildren("messages", new string[] {"kendo-breadcrumb-items"})]
  public class BreadcrumbTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    string Tag { get; set; }

    public BreadcrumbTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
      this.Tag = "nav";
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      BreadcrumbTagHelper breadcrumbTagHelper = this;
      context.Items[(object) breadcrumbTagHelper.GetType()] = (object) breadcrumbTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await breadcrumbTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag(this.Tag, this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = this.Tag;
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Breadcrumb", (IDictionary<string, object>) this.SerializeSettings());

    public string OnClick { get; set; }

    public string OnChange { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onClick = this.OnClick;
      if ((onClick != null ? (onClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.CreateHandler(this.OnClick);
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      return dictionary;
    }

    public bool? BindToLocation { get; set; }

    public string DelimiterIcon { get; set; }

    public bool? Editable { get; set; }

    [HtmlAttributeNotBound]
    public BreadcrumbItemsTagHelper Items { get; set; }

    public double? Gap { get; set; }

    [HtmlAttributeNotBound]
    public BreadcrumbMessagesSettingsTagHelper Messages { get; set; }

    public bool? Navigational { get; set; }

    public string RootIcon { get; set; }

    public string Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.BindToLocation.HasValue)
        dictionary["bindToLocation"] = (object) this.BindToLocation;
      string delimiterIcon = this.DelimiterIcon;
      if ((delimiterIcon != null ? (delimiterIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["delimiterIcon"] = (object) this.DelimiterIcon;
      if (this.Editable.HasValue)
        dictionary["editable"] = (object) this.Editable;
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<BreadcrumbItemTagHelper, Dictionary<string, object>>((Func<BreadcrumbItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      if (this.Gap.HasValue)
        dictionary["gap"] = (object) this.Gap;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.Navigational.HasValue)
        dictionary["navigational"] = (object) this.Navigational;
      string rootIcon = this.RootIcon;
      if ((rootIcon != null ? (rootIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rootIcon"] = (object) this.RootIcon;
      string str = this.Value;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
