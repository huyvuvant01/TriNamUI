// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TabStripTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-tabstrip")]
  [RestrictChildren("scrollable", new string[] {"popup-animation", "items", "ul", "div"})]
  [OutputElementHint("div")]
  public class TabStripTagHelper : TagHelperBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    IList<string> ContentUrls { get; set; }

    public IEnumerable<TabStripItemBase> BindTo { get; set; }

    [HtmlAttributeNotBound]
    public TabStripAnimationSettingsTagHelper Animation { get; set; }

    public TabStripTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
      this.ContentUrls = (IList<string>) new List<string>();
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TabStripTagHelper tabStripTagHelper = this;
      context.Items[(object) tabStripTagHelper.GetType()] = (object) tabStripTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await tabStripTagHelper.\u003C\u003En__0(context, output);
      if (tabStripTagHelper.BindTo == null)
        return;
      output.Content.Clear();
      TagHelperOutput itemsOutput = new TagHelperOutput("", new TagHelperAttributeList(), (Func<bool, HtmlEncoder, Task<TagHelperContent>>) ((useCachedResult, encoder) => Task.Factory.StartNew<TagHelperContent>((Func<TagHelperContent>) (() => (TagHelperContent) new DefaultTagHelperContent()))));
      await new TabStripItemsTagHelper()
      {
        ViewContext = tabStripTagHelper.ViewContext
      }.ProcessAsync(context, itemsOutput);
      output.Content.AppendHtml((IHtmlContent) itemsOutput);
      itemsOutput = (TagHelperOutput) null;
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.ContentUrls.Any<string>() && this.ContentUrls.Any<string>((Func<string, bool>) (item => !string.IsNullOrEmpty(item))))
        dictionary["contentUrls"] = (object) this.ContentUrls;
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Animation.Enabled.HasValue || this.Animation.Enabled.Value))
          dictionary["animation"] = (object) source;
        else if (this.Animation.Enabled.HasValue && !this.Animation.Enabled.Value)
          dictionary["animation"] = (object) this.Animation.Enabled;
      }
      return this.Initializer.Initialize(this.Selector, "TabStrip", (IDictionary<string, object>) dictionary);
    }

    public string OnActivate { get; set; }

    public string OnContentLoad { get; set; }

    public string OnError { get; set; }

    public string OnSelect { get; set; }

    public string OnShow { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onActivate = this.OnActivate;
      if ((onActivate != null ? (onActivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activate"] = (object) this.CreateHandler(this.OnActivate);
      string onContentLoad = this.OnContentLoad;
      if ((onContentLoad != null ? (onContentLoad.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentLoad"] = (object) this.CreateHandler(this.OnContentLoad);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      string onShow = this.OnShow;
      if ((onShow != null ? (onShow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["show"] = (object) this.CreateHandler(this.OnShow);
      return dictionary;
    }

    public bool? Collapsible { get; set; }

    public bool? Navigatable { get; set; }

    [HtmlAttributeNotBound]
    public TabStripScrollableSettingsTagHelper Scrollable { get; set; }

    public string TabPosition { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Collapsible.HasValue)
        dictionary["collapsible"] = (object) this.Collapsible;
      if (this.Navigatable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      if (this.Scrollable != null)
      {
        Dictionary<string, object> source = this.Scrollable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Scrollable.Enabled.HasValue || this.Scrollable.Enabled.Value))
          dictionary["scrollable"] = (object) source;
        else if (this.Scrollable.Enabled.HasValue && !this.Scrollable.Enabled.Value)
          dictionary["scrollable"] = (object) this.Scrollable.Enabled;
      }
      string tabPosition = this.TabPosition;
      if ((tabPosition != null ? (tabPosition.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["tabPosition"] = (object) this.TabPosition;
      return dictionary;
    }
  }
}
