// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TooltipTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-tooltip")]
  [RestrictChildren("popup-animation", new string[] {})]
  [OutputElementHint("div")]
  public class TooltipTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    TooltipPopupAnimationSettingsTagHelper Animation { get; set; }

    public string ContentUrl { get; set; }

    public string ContentHandler { get; set; }

    public string ContentTemplateId { get; set; }

    public TooltipTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TooltipTagHelper tooltipTagHelper = this;
      context.Items[(object) tooltipTagHelper.GetType()] = (object) tooltipTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await tooltipTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      output.TagName = (string) null;
    }

    internal virtual Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Animation.Enabled.HasValue || this.Animation.Enabled.Value))
          dictionary["animation"] = (object) source;
        else if (this.Animation.Enabled.HasValue && !this.Animation.Enabled.Value)
          dictionary["animation"] = (object) this.Animation.Enabled;
      }
      if (this.Filter.HasValue())
        dictionary["filter"] = (object) this.Filter;
      if (this.ContentUrl.HasValue())
        dictionary["content"] = (object) new Dictionary<string, object>()
        {
          {
            "url",
            (object) this.Encode(this.ContentUrl)
          }
        };
      else if (this.ContentHandler.HasValue())
        dictionary["content"] = (object) this.CreateHandler(this.ContentHandler);
      else if (!string.IsNullOrEmpty(this.ContentTemplateId))
      {
        string str = "#";
        dictionary["content"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.ContentTemplateId)
        };
      }
      return dictionary;
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Tooltip", (IDictionary<string, object>) this.Serialize());

    private string Encode(string value)
    {
      value = Regex.Replace(value, "(%20)*%23%3D(%20)*", "#=", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%23(%20)*", "#", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%24%7B(%20)*", "${", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);
      return value;
    }

    public string OnContentLoad { get; set; }

    public string OnShow { get; set; }

    public string OnHide { get; set; }

    public string OnRequestStart { get; set; }

    public string OnError { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onContentLoad = this.OnContentLoad;
      if ((onContentLoad != null ? (onContentLoad.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentLoad"] = (object) this.CreateHandler(this.OnContentLoad);
      string onShow = this.OnShow;
      if ((onShow != null ? (onShow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["show"] = (object) this.CreateHandler(this.OnShow);
      string onHide = this.OnHide;
      if ((onHide != null ? (onHide.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hide"] = (object) this.CreateHandler(this.OnHide);
      string onRequestStart = this.OnRequestStart;
      if ((onRequestStart != null ? (onRequestStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["requestStart"] = (object) this.CreateHandler(this.OnRequestStart);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      return dictionary;
    }

    public bool? AutoHide { get; set; }

    public bool? Callout { get; set; }

    public string Filter { get; set; }

    public bool? Iframe { get; set; }

    public double? Height { get; set; }

    public double? Width { get; set; }

    public string Position { get; set; }

    public double? ShowAfter { get; set; }

    public string ShowOn { get; set; }

    public double? HideAfter { get; set; }

    public double? Offset { get; set; }

    public string Content { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoHide.HasValue)
        dictionary["autoHide"] = (object) this.AutoHide;
      if (this.Callout.HasValue)
        dictionary["callout"] = (object) this.Callout;
      if (this.Iframe.HasValue)
        dictionary["iframe"] = (object) this.Iframe;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      if (this.ShowAfter.HasValue)
        dictionary["showAfter"] = (object) this.ShowAfter;
      string showOn = this.ShowOn;
      if ((showOn != null ? (showOn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showOn"] = (object) this.ShowOn;
      if (this.HideAfter.HasValue)
        dictionary["hideAfter"] = (object) this.HideAfter;
      if (this.Offset.HasValue)
        dictionary["offset"] = (object) this.Offset;
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["content"] = (object) this.Content;
      return dictionary;
    }
  }
}
